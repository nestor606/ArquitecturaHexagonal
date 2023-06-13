using Datos.Contexto;
using Microsoft.EntityFrameworkCore;
using Datos.Common;

var builder = WebApplication.CreateBuilder(args);

#region "Servicio Connection Oracle"

//var cadenaConexion = builder.Configuration.GetConnectionString("OraclConnection");

builder.Services.AddDbContext<AplicacionDbContext>(x =>
{
    x.UseNpgsql(
        builder.Configuration.GetConnectionString("Pgsql"),
        b => b.MigrationsAssembly("Datos")
        );
   
});
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

app.MapControllers();

app.Run();
