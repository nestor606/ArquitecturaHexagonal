using Datos.Contexto;
using Microsoft.EntityFrameworkCore;
using Datos.Common;
using Microsoft.AspNetCore.Authentication;
using Keycloak.AuthServices.Authentication;
using Keycloak.AuthServices.Authorization;
using Keycloak.AuthServices.Sdk.Admin;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);



#region "Servicio Connection postgres"

//var cadenaConexion = builder.Configuration.GetConnectionString("OraclConnection");

builder.Services.AddDbContext<AplicacionDbContext>(x =>
{
    x.UseNpgsql(
        builder.Configuration.GetConnectionString("Pgsql"),
        b => b.MigrationsAssembly("Datos")
        );
   
});
#endregion


#region "Setting Keycloak"


//Authenticacion
var authenticationOptions = builder.Configuration.GetSection(KeycloakAuthenticationOptions.Section)
.Get<KeycloakAuthenticationOptions>();

builder.Services.AddKeycloakAuthentication(authenticationOptions);

//Authorizacion
var authorizationOptions = builder.Configuration
    .GetSection(KeycloakProtectionClientOptions.Section)
    .Get<KeycloakProtectionClientOptions>();


builder.Services
    .AddAuthorization(o => o.AddPolicy("IsAdmin", b =>
    {
        b.RequireRealmRoles("admin");
        b.RequireResourceRoles("r-admin");
       
        b.RequireRole("r-admin");
    }))
    .AddKeycloakAuthorization(authorizationOptions);

var adminClientOptions = builder.Configuration
    .GetSection(KeycloakAdminClientOptions.Section)
    .Get<KeycloakAdminClientOptions>();

builder.Services.AddKeycloakAdminHttpClient(adminClientOptions);

#endregion

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCommonLayer();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();


app.MapControllers();

app.Run();
