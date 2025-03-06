using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Flurl;

namespace WinForms.Client
{
    public static class DataServiceClient
    {
        public class BearerTokenHandler : DelegatingHandler
        {
            public BearerTokenHandler()
            {
                InnerHandler = new HttpClientHandler();
            }

            protected override async Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request,
                CancellationToken cancellationToken
            )
            {
                if (!String.IsNullOrWhiteSpace(accessToken))
                {
                    if (
                        !String.IsNullOrWhiteSpace(refreshToken)
                        && lastRefreshed.HasValue
                        && expiresIn.HasValue
                        && DateTime.Now - lastRefreshed
                            > TimeSpan.FromSeconds((int)(expiresIn - 60))
                    )
                    {
                        CheckSettings(["authUrl", "realm", "clientId"]);

                        var content = new FormUrlEncodedContent(
                            new Dictionary<string, string>
                            {
                                { "grant_type", "refresh_token" },
                                { "client_id", clientId! },
                                { "refresh_token", refreshToken },
                            }
                        );

                        var url = Url.Combine(
                            authUrl,
                            "realms",
                            realm,
                            "protocol",
                            "openid-connect",
                            "token"
                        );
                        var response = await bareHttpClient.PostAsync(url, content);
                        response.EnsureSuccessStatusCode();
                        var responseString = await response.Content.ReadAsStringAsync();
                        // According to various docs, some of these return fields are optional, while the presence of
                        // others depends on Keycloak version or configuration. So we better be careful not to
                        // overwrite anything with nulls.
                        var (newIdToken, newAccessToken, newRefreshToken, newExpiresIn) = GetTokens(
                            responseString
                        );
                        if (newIdToken != null)
                            idToken = newIdToken;
                        if (newAccessToken != null)
                        {
                            lastRefreshed = DateTime.Now;
                            (name, realmRoles) = GetUserDetails(newAccessToken);
                            accessToken = newAccessToken;
                        }
                        if (newRefreshToken != null)
                            refreshToken = newRefreshToken;
                        if (newExpiresIn != null)
                            expiresIn = newExpiresIn;
                    }
                    request.Headers.Authorization = new AuthenticationHeaderValue(
                        "Bearer",
                        accessToken
                    );
                }
                return await base.SendAsync(request, cancellationToken);
            }
        }

        static void CheckSettings(ReadOnlySpan<string> settings)
        {
            foreach (var setting in settings)
            {
                if (string.IsNullOrEmpty(setting))
                    throw new InvalidOperationException(
                        $"The '{setting}' configuration setting is missing."
                    );
            }
        }

        static DataServiceClient()
        {
            CheckSettings(["baseUrl"]);
        }

        static string? baseUrl = System.Configuration.ConfigurationManager.AppSettings["baseUrl"];

        static string? idToken;
        static string? accessToken;
        public static bool LoggedIn => accessToken != null;
        static string? refreshToken;
        static int? expiresIn;
        static DateTime? lastRefreshed;
        static string? name;
        public static string? Name => name;
        static string?[]? realmRoles;

        public static bool UserHasRole(string role) =>
            realmRoles != null && realmRoles.Contains(role);

        static string? redirectUri = System.Configuration.ConfigurationManager.AppSettings[
            "redirectUri"
        ];
        static string? clientId = System.Configuration.ConfigurationManager.AppSettings["clientId"];
        static string? realm = System.Configuration.ConfigurationManager.AppSettings["realm"];
        static string? authUrl = System.Configuration.ConfigurationManager.AppSettings["authUrl"];

        static HttpClient bareHttpClient = new HttpClient();

        static (
            string? id_token,
            string? access_token,
            string? refresh_token,
            int? expires_in
        ) GetTokens(string jsonString)
        {
            var node = JsonNode.Parse(jsonString);
            if (node == null)
                return (null, null, null, null);
            else
                return (
                    node["id_token"]?.GetValue<string>(),
                    node["access_token"]?.GetValue<string>(),
                    node["refresh_token"]?.GetValue<string>(),
                    node["expires_in"]?.GetValue<int>()
                );
        }

        static (string? name, string?[] realmRoles) GetUserDetails(string? accessToken)
        {
            if (String.IsNullOrEmpty(accessToken))
                return (null, []);
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(accessToken);

            var claim = (string claimType) =>
                token.Claims.FirstOrDefault(c => c.Type == claimType)?.Value;
            var name = claim("name");
            var realmAccess = claim("realm_access");
            var node = JsonNode.Parse(realmAccess);
            if (node == null || node["roles"] == null)
                return (name, []);
            var array = node["roles"]!.AsArray();
            var realmRoles = array.Select(r => r?.GetValue<string>()).ToArray();

            return (name, realmRoles);
        }

        public static event EventHandler? LogInStatusChanged;

        public static void LogIn()
        {
            CheckSettings(["authUrl", "realm", "clientId", "redirectUri"]);

            var url = Url.Combine(authUrl, "realms", realm, "protocol", "openid-connect", "auth")
                .SetQueryParams(
                    new
                    {
                        response_type = "code",
                        client_id = clientId,
                        redirect_uri = redirectUri,
                        // Note that Keycloak may not make the scope "openid" availably by default. If necessary,
                        // create it in the Client scopes list for your realm, and add it to the Client scopes
                        // list of your client registration.
                        scope = "openid profile email",
                    }
                );

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        public static async Task AcceptProtocolUrl(string protocolUrlString)
        {
            var protocolUrl = new Url(protocolUrlString);
            if (
                protocolUrl.QueryParams.TryGetFirst("code", out object codeObject)
                && codeObject is string code
            )
            {
                CheckSettings(["authUrl", "realm", "clientId", "redirectUri"]);

                var content = new FormUrlEncodedContent(
                    new Dictionary<string, string>
                    {
                        { "grant_type", "authorization_code" },
                        { "client_id", clientId! },
                        { "code", code },
                        { "redirect_uri", redirectUri! },
                    }
                );
                var url = Url.Combine(
                    authUrl,
                    "realms",
                    realm,
                    "protocol",
                    "openid-connect",
                    "token"
                );

                var response = await bareHttpClient.PostAsync(url, content);
                try
                {
                    response.EnsureSuccessStatusCode();
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    (idToken, accessToken, refreshToken, expiresIn) = GetTokens(responseString);
                    if (accessToken != null)
                    {
                        lastRefreshed = DateTime.Now;
                        (name, realmRoles) = GetUserDetails(accessToken);
                        LogInStatusChanged?.Invoke(null, EventArgs.Empty);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                idToken = null;
                accessToken = null;
                refreshToken = null;
                expiresIn = null;
                lastRefreshed = null;
                name = null;
                realmRoles = null;
                LogInStatusChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static void LogOut()
        {
            var url = Url.Combine(authUrl, "realms", realm, "protocol", "openid-connect", "logout")
                .SetQueryParams(
                    new { post_logout_redirect_uri = redirectUri, id_token_hint = idToken }
                );

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        static HttpClient authorizedHttpClient = new HttpClient(new BearerTokenHandler());

        public static async Task<DataFetchResult?> GetOrderItemsAsync(
            int skip,
            int take,
            string sortField,
            bool sortAscending
        )
        {
            var response = await authorizedHttpClient.GetAsync(
                $"{baseUrl}/data/OrderItems?skip={skip}&take={take}&sortField={sortField}&sortAscending={sortAscending}"
            );
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();

            var dataFetchResult = JsonSerializer.Deserialize<DataFetchResult>(
                responseBody,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
            return dataFetchResult;
        }

        static OrderItem? AsOrderItem(this string responseBody)
        {
            return JsonSerializer.Deserialize<OrderItem>(
                responseBody,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        public static async Task<OrderItem?> GetOrderItemAsync(int id)
        {
            var response = await authorizedHttpClient.GetAsync($"{baseUrl}/data/OrderItem/{id}");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody.AsOrderItem();
        }

        public static async Task<OrderItem?> CreateOrderItemAsync(OrderItem orderItem)
        {
            var response = await authorizedHttpClient.PostAsync(
                $"{baseUrl}/data/OrderItem",
                new StringContent(
                    JsonSerializer.Serialize(orderItem),
                    Encoding.UTF8,
                    "application/json"
                )
            );
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody.AsOrderItem();
        }

        public static async Task UpdateOrderItemAsync(OrderItem orderItem)
        {
            var response = await authorizedHttpClient.PutAsync(
                $"{baseUrl}/data/OrderItem/{orderItem.Id}",
                new StringContent(
                    JsonSerializer.Serialize(orderItem),
                    Encoding.UTF8,
                    "application/json"
                )
            );
            response.EnsureSuccessStatusCode();
        }

        public static async Task<bool> DeleteOrderItemAsync(int id)
        {
            try
            {
                var response = await authorizedHttpClient.DeleteAsync(
                    $"{baseUrl}/data/OrderItem/{id}"
                );
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }
    }
}
