Imports System.Diagnostics
Imports System.IdentityModel.Tokens.Jwt
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text.Json
Imports System.Text.Json.Nodes
Imports Flurl

Namespace WinForms.Client

    Public Module DataServiceClient

        Public Class BearerTokenHandler
            Inherits DelegatingHandler

            Public Sub New()
                InnerHandler = New HttpClientHandler()
            End Sub

            Protected Overrides Async Function SendAsync(ByVal request As HttpRequestMessage, ByVal cancellationToken As CancellationToken) As Task(Of HttpResponseMessage)
                Dim newIdTokenNewAccessTokenNewRefreshTokenNewExpiresIn = Nothing
                If Not [String].IsNullOrWhiteSpace(accessToken) Then
                    If Not [String].IsNullOrWhiteSpace(refreshToken) AndAlso lastRefreshed.HasValue AndAlso expiresIn.HasValue AndAlso DateTime.Now - lastRefreshed > TimeSpan.FromSeconds(CInt(expiresIn - 60)) Then
                        CheckSettings()("authUrl", "realm", "clientId")
                         ''' Cannot convert LocalDeclarationStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommonConversions.cs:line 478
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\MethodBodyExecutableStatementVisitor.cs:line 59
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingMethodBodyVisitor.cs:line 24
''' 
''' Input:
''' 
'''                         var content = new FormUrlEncodedContent(
'''                             new Dictionary<string, string>
'''                             {
'''                                 { "grant_type", "refresh_token" },
'''                                 { "client_id", WinForms.Client.DataServiceClient.clientId! },
'''                                 { "refresh_token", WinForms.Client.DataServiceClient.refreshToken },
'''                             }
'''                         );
''' 
'''  Dim url = Flurl.Url.Combine(authUrl, "realms", realm, "protocol", "openid-connect", "token")
                        Dim response = Await bareHttpClient.PostAsync(url, content)
                        response.EnsureSuccessStatusCode()
                        Dim responseString = Await response.Content.ReadAsStringAsync()
                        ' According to various docs, some of these return fields are optional, while the presence of
                        ' others depends on Keycloak version or configuration. So we better be careful not to
                        ' overwrite anything with nulls.
                        newIdTokenNewAccessTokenNewRefreshTokenNewExpiresIn = GetTokens(responseString)
                        If newIdToken IsNot Nothing Then idToken = newIdToken
                        If newAccessToken IsNot Nothing Then
                            lastRefreshed = DateTime.Now
                            (nameField, DataServiceClient.realmRoles) = DataServiceClient.GetUserDetails(newAccessToken)
                            accessToken = newAccessToken
                        End If

                        If newRefreshToken IsNot Nothing Then refreshToken = newRefreshToken
                        If newExpiresIn IsNot Nothing Then expiresIn = newExpiresIn
                    End If

                    request.Headers.Authorization = New AuthenticationHeaderValue("Bearer", accessToken)
                End If

                Return Await MyBase.SendAsync(request, cancellationToken)
            End Function
        End Class

        Private Sub CheckSettings(ByVal settings As ReadOnlySpan(Of String))
            For Each setting In settings
                If String.IsNullOrEmpty(setting) Then Throw New InvalidOperationException($"The '{setting}' configuration setting is missing.")
            Next
        End Sub

        Sub New()
            CheckSettings()("baseUrl")
        End Sub

        Private baseUrl As String? = System.Configuration.ConfigurationManager.AppSettings("baseUrl")

        Private idToken As String?

        Private accessToken As String?

        Public ReadOnly Property LoggedIn As Boolean
            Get
                Return accessToken IsNot Nothing
            End Get
        End Property

        Private refreshToken As String?

        Private expiresIn As Integer?

        Private lastRefreshed As DateTime?

        Private nameField As String?

        Public ReadOnly Property Name As String?
            Get
                Return nameField
            End Get
        End Property

         ''' Cannot convert FieldDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeSyntax'.
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommonConversions.cs:line 478
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 455
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''         static string?[]? realmRoles;
''' 
'''  Public Function UserHasRole(ByVal role As String) As Boolean
            Return DataServiceClient.realmRoles IsNot Nothing AndAlso DataServiceClient.realmRoles.Contains(role)
        End Function

        Private redirectUri As String? = System.Configuration.ConfigurationManager.AppSettings("redirectUri")

        Private clientId As String? = System.Configuration.ConfigurationManager.AppSettings("clientId")

        Private realm As String? = System.Configuration.ConfigurationManager.AppSettings("realm")

        Private authUrl As String? = System.Configuration.ConfigurationManager.AppSettings("authUrl")

        Private bareHttpClient As HttpClient = New HttpClient()

        Private Function GetTokens(ByVal jsonString As String) As(String?, String?, String?, Integer?)
            Dim node = JsonNode.Parse(jsonString)
            If node Is Nothing Then
                Return(Nothing, Nothing, Nothing, Nothing)
            Else
                Return(node("id_token")?.GetValue(Of String)(), node("access_token")?.GetValue(Of String)(), node("refresh_token")?.GetValue(Of String)(), node("expires_in")?.GetValue(Of Integer)())
            End If
        End Function

        Private Function GetUserDetails(ByVal accessToken As String?) As(String?, String?())
            If [String].IsNullOrEmpty(accessToken) Then Return(Nothing, _(_))
            Dim handler = New JwtSecurityTokenHandler()
            Dim token = handler.ReadJwtToken(accessToken)
            Dim claim = Function(ByVal claimType As String) token.Claims.FirstOrDefault(Function(c) c.Type Is claimType)?.Value
            Dim name = claim("name")
            Dim realmAccess = claim("realm_access")
            Dim node = JsonNode.Parse(realmAccess)
            If node Is Nothing OrElse node("roles") Is Nothing Then Return(name, _(_))
             ''' Cannot convert LocalDeclarationStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommonConversions.cs:line 478
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\MethodBodyExecutableStatementVisitor.cs:line 59
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingMethodBodyVisitor.cs:line 24
''' 
''' Input:
'''             var array = node["roles"]!.AsArray();
''' 
'''  Dim realmRoles = array.[Select](Function(r) r?.GetValue(Of String)()).ToArray()
            Return(name, realmRoles)
        End Function

        Public Event LogInStatusChanged As EventHandler?

        Public Sub LogIn()
            CheckSettings()("authUrl", "realm", "clientId", "redirectUri")
            ' Note that Keycloak may not make the scope "openid" availably by default. If necessary,
            ' create it in the Client scopes list for your realm, and add it to the Client scopes
            ' list of your client registration.
            Dim url = Flurl.Url.Combine(authUrl, "realms", realm, "protocol", "openid-connect", "auth").SetQueryParams(New With {.response_type = "code", .client_id = clientId, .redirect_uri = redirectUri, .scope = "openid profile email"})
            Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
        End Sub

        Public Async Function AcceptProtocolUrl(ByVal protocolUrlString As String) As Task
            Dim protocolUrl = New Url(protocolUrlString)
            Dim codeObject As Object = Nothing, code As String = Nothing
            If protocolUrl.QueryParams.TryGetFirst("code", codeObject) AndAlso CSharpImpl.__Assign(code, TryCast(codeObject, String)) IsNot Nothing Then
                CheckSettings()("authUrl", "realm", "clientId", "redirectUri")
                 ''' Cannot convert LocalDeclarationStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommonConversions.cs:line 478
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\MethodBodyExecutableStatementVisitor.cs:line 59
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingMethodBodyVisitor.cs:line 24
''' 
''' Input:
''' 
'''                 var content = new FormUrlEncodedContent(
'''                     new Dictionary<string, string>
'''                     {
'''                         { "grant_type", "authorization_code" },
'''                         { "client_id", WinForms.Client.DataServiceClient.clientId! },
'''                         { "code", code },
'''                         { "redirect_uri", WinForms.Client.DataServiceClient.redirectUri! },
'''                     }
'''                 );
''' 
'''  Dim url = Flurl.Url.Combine(authUrl, "realms", realm, "protocol", "openid-connect", "token")
                Dim response = Await bareHttpClient.PostAsync(url, content)
                Try
                    response.EnsureSuccessStatusCode()
                    Dim responseString = response.Content.ReadAsStringAsync().Result
                    (idToken, accessToken, refreshToken, expiresIn) = GetTokens(responseString)
                    If accessToken IsNot Nothing Then
                        lastRefreshed = DateTime.Now
                        (nameField, DataServiceClient.realmRoles) = DataServiceClient.GetUserDetails(accessToken)
                        RaiseEvent LogInStatusChangedEvent(Nothing, EventArgs.Empty)
                    End If
                Catch ex As Exception
                    Debug.WriteLine(ex)
                End Try
            Else
                WinForms.Client.DataServiceClient.idToken = Nothing
                WinForms.Client.DataServiceClient.accessToken = Nothing
                WinForms.Client.DataServiceClient.refreshToken = Nothing
                WinForms.Client.DataServiceClient.expiresIn = Nothing
                WinForms.Client.DataServiceClient.lastRefreshed = Nothing
                WinForms.Client.DataServiceClient.nameField = Nothing
                WinForms.Client.DataServiceClient.realmRoles = Nothing
                RaiseEvent LogInStatusChangedEvent(Nothing, EventArgs.Empty)
            End If
        End Function

        Public Sub LogOut()
            Dim url = Flurl.Url.Combine(authUrl, "realms", realm, "protocol", "openid-connect", "logout").SetQueryParams(New With {.post_logout_redirect_uri = redirectUri, .id_token_hint = idToken})
            Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
        End Sub

        Private authorizedHttpClient As HttpClient = New HttpClient(New BearerTokenHandler())

        Public Async Function GetOrderItemsAsync(ByVal skip As Integer, ByVal take As Integer, ByVal sortField As String, ByVal sortAscending As Boolean) As Task(Of DataFetchResult?)
            Dim response = Await authorizedHttpClient.GetAsync($"{baseUrl}/data/OrderItems?skip={skip}&take={take}&sortField={sortField}&sortAscending={sortAscending}")
            response.EnsureSuccessStatusCode()
            Dim responseBody = Await response.Content.ReadAsStringAsync()
            Dim dataFetchResult = JsonSerializer.Deserialize(Of DataFetchResult)(responseBody, New JsonSerializerOptions With {.PropertyNameCaseInsensitive = True})
            Return dataFetchResult
        End Function

        <Extension()>
        Private Function AsOrderItem(ByVal responseBody As String) As OrderItem?
            Return JsonSerializer.Deserialize(Of OrderItem)(responseBody, New JsonSerializerOptions With {.PropertyNameCaseInsensitive = True})
        End Function

        Public Async Function GetOrderItemAsync(ByVal id As Integer) As Task(Of OrderItem?)
            Dim response = Await authorizedHttpClient.GetAsync($"{baseUrl}/data/OrderItem/{id}")
            response.EnsureSuccessStatusCode()
            Dim responseBody = Await response.Content.ReadAsStringAsync()
            Return responseBody.AsOrderItem()
        End Function

        Public Async Function CreateOrderItemAsync(ByVal orderItem As OrderItem) As Task(Of OrderItem?)
            Dim response = Await authorizedHttpClient.PostAsync($"{baseUrl}/data/OrderItem", New StringContent(JsonSerializer.Serialize(orderItem), Encoding.UTF8, "application/json"))
            response.EnsureSuccessStatusCode()
            Dim responseBody = Await response.Content.ReadAsStringAsync()
            Return responseBody.AsOrderItem()
        End Function

        Public Async Function UpdateOrderItemAsync(ByVal orderItem As OrderItem) As Task
            Dim response = Await authorizedHttpClient.PutAsync($"{baseUrl}/data/OrderItem/{orderItem.Id}", New StringContent(JsonSerializer.Serialize(orderItem), Encoding.UTF8, "application/json"))
            response.EnsureSuccessStatusCode()
        End Function

        Public Async Function DeleteOrderItemAsync(ByVal id As Integer) As Task(Of Boolean)
            Try
                Dim response = Await authorizedHttpClient.DeleteAsync($"{baseUrl}/data/OrderItem/{id}")
                response.EnsureSuccessStatusCode()
                Return True
            Catch ex As Exception
                Debug.WriteLine(ex)
                Return False
            End Try
        End Function

        Private Class CSharpImpl

            <System.Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Module
End Namespace
