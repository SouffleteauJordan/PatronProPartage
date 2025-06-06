using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PatronProPartage.Data;
using PatronProPartage.Models;
using PatronProPartage.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Database context for Identity and other entities
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("PatronProPartage"));

// ASP.NET Core Identity with role support
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<IPatronService, InMemoryPatronService>();
builder.Services.AddSingleton<IUserService, InMemoryUserService>();
builder.Services.AddSingleton<IFileStorageService, LocalFileStorageService>();
// MudBlazor services would be added here

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapRazorPages();

await SeedRoles(app.Services);

app.Run();

static async Task SeedRoles(IServiceProvider services)
{
    using var scope = services.CreateScope();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    await IdentityDataInitializer.SeedAsync(userManager, roleManager);
}
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
