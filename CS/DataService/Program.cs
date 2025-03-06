using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text.Json.Nodes;
using System.Xml.Serialization;
using DataService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

var publicKey = await GetKeycloakPublicKey(
    builder.Configuration["Jwt:KeycloakUrl"]!,
    builder.Configuration["Jwt:Realm"]!
);

builder
    .Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false; // Development only!!

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer =
                $"{builder.Configuration["Jwt:KeycloakUrl"]}/realms/{builder.Configuration["Jwt:Realm"]}",
            ValidateAudience = true,
            ValidAudience = builder.Configuration["Jwt:Audience"],
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = publicKey,
        };
    });
builder.Services.AddAuthorization(o =>
{
    o.AddPolicy("writers", p => p.RequireRealmRole("writers"));
});

string? connectionString = builder.Configuration.GetConnectionString("SqlExpressConnectionString");

builder.Services.AddDbContext<DataServiceDbContext>(o =>
    o.UseSqlServer(
        connectionString,
        options =>
        {
            options.EnableRetryOnFailure();
        }
    )
);

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();

// Make sure the database exists and is current
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DataServiceDbContext>();
    dbContext.Database.Migrate();
}

// Note that this endpoint is NOT configured to require authorization. For the demo,
// this makes it possible to populate the database with test data without having to
// authenticate first. In a real-world application, you would want to secure this endpoint.

app.MapGet(
    "/api/populateTestData",
    async (DataServiceDbContext dbContext) =>
    {
        var assembly = Assembly.GetExecutingAssembly();
        Console.WriteLine(String.Join("\n", assembly.GetManifestResourceNames()));
        var resourceName = assembly
            .GetManifestResourceNames()
            .Single(str => str.EndsWith("order_items.xml"));

        var serializer = new XmlSerializer(typeof(List<OrderItem>));

        using Stream? stream = assembly.GetManifestResourceStream(resourceName);
        if (stream is not null)
        {
            var items = (List<OrderItem>?)serializer.Deserialize(stream);

            if (items is not null)
            {
                dbContext.OrderItems.AddRange(items);
                await dbContext.SaveChangesAsync();
                return Results.Ok("Data populated successfully");
            }
        }

        return Results.NotFound("Error populating data");
    }
);

// The following two endpoints are read-only, so they only require an authenticated user.

app.MapGet(
        "/data/OrderItems",
        async (
            DataServiceDbContext dbContext,
            int skip = 0,
            int take = 20,
            string sortField = "Id",
            bool sortAscending = true
        ) =>
        {
            var source = dbContext
                .OrderItems.AsQueryable()
                .OrderBy(sortField + (sortAscending ? " ascending" : " descending"));
            var items = await source.Skip(skip).Take(take).ToListAsync();

            var totalCount = await dbContext.OrderItems.CountAsync();

            return Results.Ok(new { Items = items, TotalCount = totalCount });
        }
    )
    .RequireAuthorization();

app.MapGet(
        "/data/OrderItem/{id}",
        async (DataServiceDbContext dbContext, int id) =>
        {
            var orderItem = await dbContext.OrderItems.FindAsync(id);

            if (orderItem is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(orderItem);
        }
    )
    .RequireAuthorization();

// The following endpoints are read-write, so they require an authenticated user and
// compliance with the "writers" policy.

app.MapPost(
        "/data/OrderItem",
        async (DataServiceDbContext dbContext, OrderItem orderItem) =>
        {
            dbContext.OrderItems.Add(orderItem);
            await dbContext.SaveChangesAsync();
            return Results.Created($"/data/OrderItem/{orderItem.Id}", orderItem);
        }
    )
    .RequireAuthorization("writers");

app.MapPut(
        "/data/OrderItem/{id}",
        async (DataServiceDbContext dbContext, int id, OrderItem orderItem) =>
        {
            if (id != orderItem.Id)
            {
                return Results.BadRequest("Id mismatch");
            }

            dbContext.Entry(orderItem).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return Results.NoContent();
        }
    )
    .RequireAuthorization("writers");

app.MapDelete(
        "/data/OrderItem/{id}",
        async (DataServiceDbContext dbContext, int id) =>
        {
            var orderItem = await dbContext.OrderItems.FindAsync(id);

            if (orderItem is null)
            {
                return Results.NotFound();
            }

            dbContext.OrderItems.Remove(orderItem);
            await dbContext.SaveChangesAsync();
            return Results.NoContent();
        }
    )
    .RequireAuthorization("writers");

app.Run();

static async Task<SecurityKey> GetKeycloakPublicKey(string keycloakUrl, string realm)
{
    using (var httpClient = new HttpClient())
    {
        var jwksUrl = $"{keycloakUrl}/realms/{realm}/protocol/openid-connect/certs";
        var jwksJson = await httpClient.GetStringAsync(jwksUrl);
        var jwks = new JsonWebKeySet(jwksJson);
        return jwks.Keys[0];
    }
}

public static class PolicyHelpers
{
    public static void RequireRealmRole(this AuthorizationPolicyBuilder policy, string roleName)
    {
        policy.RequireAssertion(context =>
        {
            var realmAccess = context.User.FindFirst("realm_access")?.Value;
            if (realmAccess == null)
                return false;
            var node = JsonNode.Parse(realmAccess);
            if (node == null || node["roles"] == null)
                return false;
            var array = node["roles"]!.AsArray();
            return array.Select(r => r?.GetValue<string>()).Contains(roleName);
        });
    }
}
