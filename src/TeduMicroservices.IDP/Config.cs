using Duende.IdentityServer.Models;

namespace TeduMicroservices.IDP;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            {
              new("tedu_microservices_api.read", "Tedu Microservices API Read Scope"),
              new("tedu_microservices_api.write", "Tedu Microservices API Write Scope")
            };

    public static IEnumerable<ApiResource> ApiResources =>
       new ApiResource[]
       {
            new ApiResource("tedu_microservices_api", "Tedu Microservices API")
            {
                Scopes = new List<string> { "tedu_microservices_api.read", "tedu_microservices_api.write" },
                UserClaims = new List<string> { "roles" }
            }
       };

    public static IEnumerable<Client> Clients =>
        new Client[]
            {

            };
}