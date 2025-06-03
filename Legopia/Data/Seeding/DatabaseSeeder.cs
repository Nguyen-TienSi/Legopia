using Legopia.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace Legopia.Data.Seeding
{
    public static class DatabaseSeeder
    {
        public static async Task SeedAdminAsync(UserManager<UserDetails> userManager, RoleManager<UserRole> roleManager)
        {
            const string adminRole = "Admin";
            const string adminEmail = "admin@legopia.com";
            const string adminUserName = "admin";
            const string adminPassword = "Admin@123"; // Change for production!

            // Ensure Admin role exists
            if (!await roleManager.RoleExistsAsync(adminRole))
            {
                await roleManager.CreateAsync(new UserRole { Name = adminRole });
            }

            // Ensure Admin user exists
            var adminUser = await userManager.FindByNameAsync(adminUserName);
            if (adminUser == null)
            {
                adminUser = new UserDetails
                {
                    UserName = adminUserName,
                    Email = adminEmail,
                    EmailConfirmed = true,
                    FirstName = "Admin",
                    LastName = "User"
                };
                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, adminRole);
                }
            }
            else
            {
                // Ensure user is in Admin role
                if (!await userManager.IsInRoleAsync(adminUser, adminRole))
                {
                    await userManager.AddToRoleAsync(adminUser, adminRole);
                }
            }
        }
    }
}
