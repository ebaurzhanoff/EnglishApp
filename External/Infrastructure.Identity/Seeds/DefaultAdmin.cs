using Domain.Common;
using Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity.Seeds;

public static class DefaultAdmin
{
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        var adminUser = new ApplicationUser
        {
            UserName = "admin",
            Email = "admin@gmail.com",
            FirstName = "Admin",
            LastName = "Admin",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true
        };

        if (userManager.Users.All(u => u.Id != adminUser.Id))
        {
            var existUser = await userManager.FindByEmailAsync(adminUser.Email);
            if (existUser == null)
            {
                await userManager.CreateAsync(adminUser, "Pa$$word!123");
                await userManager.AddToRoleAsync(adminUser, Roles.Admin.ToString());
            }
        }
    }
}
