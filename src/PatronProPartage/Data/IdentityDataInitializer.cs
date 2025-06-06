using Microsoft.AspNetCore.Identity;
using PatronProPartage.Models;

namespace PatronProPartage.Data;

public static class IdentityDataInitializer
{
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager,
                                       RoleManager<IdentityRole> roleManager)
    {
        string[] roles = new[] { "Admin", "Moderator", "Premium", "Contributor", "User" };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        // Additional seeding like creating a default admin user could be placed here
    }
}
