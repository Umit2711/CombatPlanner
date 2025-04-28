using CombatPlanner.Client;
using CombatPlanner.Client.Interfaces;
using CombatPlanner.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7228/") });
builder.Services.AddScoped<IAuthService, AuthService>();

await builder.Build().RunAsync();
