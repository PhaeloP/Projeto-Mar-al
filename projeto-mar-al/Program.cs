using projeto_mar_al.APPLICATION;
using projeto_mar_al.DOMAIN.Interfaces;
using projeto_mar_al.INFRA.Providers;
using projeto_mar_al.INFRA.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<ObterClientes>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<MySqlConnectionFactory>();

var app = builder.Build();

app.MapControllers();

app.Run();