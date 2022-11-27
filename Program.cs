using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;
using NutrifoodsFrontend.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddAuth0WebAppAuthentication(options => {
        options.Domain = builder.Configuration["Auth0:Domain"];
        options.ClientId = builder.Configuration["Auth0:ClientId"];
    });

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<IngredientService>();
builder.Services.AddSingleton<MealPlanService>();
builder.Services.AddSingleton<RecipeService>();
builder.Services.AddSingleton<UserService>();
builder.Services.AddHttpClient<IIngredientService, IngredientService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7212/");
});
builder.Services.AddHttpClient<IMealPlanService, MealPlanService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7212/");
});
builder.Services.AddHttpClient<IRecipeService, RecipeService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7212/");
});
builder.Services.AddHttpClient<IUserService, UserService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7212/");
});
builder.Services.AddMudServices();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();