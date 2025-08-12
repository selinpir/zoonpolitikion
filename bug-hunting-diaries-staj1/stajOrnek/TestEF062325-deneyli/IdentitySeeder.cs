using Microsoft.AspNetCore.Identity;
using TestEF062325.Data;

namespace TestEF062325
{
    public static class IdentitySeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            try
            {

            //var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            //// Define roles to seed
            //var roles = new[] { "Admin", "Driver", "Customer" };

            //// Seed roles
            //foreach (var role in roles)
            //{
            //    if (!await roleManager.RoleExistsAsync(role))
            //    {
            //        await roleManager.CreateAsync(new ApplicationRole(role));
            //    }
            //}

            // Define the admin user details
            var adminEmail = "admin@admin.com";
            var adminPassword = "Admin@123";

            // Check if the admin user already exists
            var userExist = await userManager.FindByEmailAsync(adminEmail);
            if (userExist == null)
            {
                    var adminUser = new ApplicationUser
                    {
                        UserName = adminEmail, // << Email ile aynı yaptık
                        Email = adminEmail,
                        PhoneNumber = "0712345678",
                        EmailConfirmed = true
                    };


                    // Create the admin user
                    var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    // Assign the Admin role to the user
                    //await userManager.AddToRoleAsync(adminUser, "Admin");
                }
                else
                {
                    throw new Exception("Failed to create the admin user: " + string.Join(", ", result.Errors));
                }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Seeder hatası: " + ex.Message);
            }
        }
    }
}
