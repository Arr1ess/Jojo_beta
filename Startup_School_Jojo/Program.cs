using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using DateBaseLogic;
using Startup_School_Jojo.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Startup_School_Jojo.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddRazorPages().AddRazorPagesOptions(options => options.RootDirectory = "/Layouts");
builder.Services.AddSingleton<DB>();

var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbUser = Environment.GetEnvironmentVariable("DB_USER");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(
    $"Host={dbHost}; Database={dbName}; Username={dbUser}; Password={dbPassword}; Include Error Detail=True;"
));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapHub<CodeEditorHub>("/codeEditor");
app.MapFallbackToPage("/_Host");

app.Run();
