using Microsoft.Extensions.DependencyInjection;
using JorgeManzano.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddEnvironmentVariables().Build();

// Add services to the container.
builder.Services.AddRazorPages();
// Esto hace que se pueda hacer una inyeccion de dependencias con IRepositorio y RepositorioDB
builder.Services.AddTransient<IEquipoRepositorio, EquipoRepositorioDB>(); // Por cada tabla
builder.Services.AddTransient<IJugadorRepositorio, JugadorRepositorioDB>(); // Por cada tabla

builder.Services.AddDbContextPool<FutbolDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("FutbolDbConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
