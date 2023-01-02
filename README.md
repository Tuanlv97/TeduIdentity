# TeduIdentity
1: dotnet new -i Duende.IdentityServer.Templates
2: dotnet new isempty -n TeduMicroservices.IDP
3: Cd TeduMicroservices => dotnet new isui
# Add Migrations
1: Add-Migration InitialPersistedGrantMigration -c PersistedGrantDbContext -o Persistence/Migraions/IdentityServer/PersistedGrantDb
2: Add-Migration InitialConfigurationMigration -c ConfigurationDbContext -o Persistence/Migraions/IdentityServer/ConfigurationDb
3: dotnet ef database update -c PersistedGrantDbContext
4: dotnet ef database update -c ConfigurationDbContext
5: Add-Migration InitialTeduIdentityMigration -c TeduIdentityContext -o Persistence/Migraions
6: dotnet ef database update -c TeduIdentityContext