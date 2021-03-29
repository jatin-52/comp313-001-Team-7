using Microsoft.AspNetCore.Identity;

namespace SecondHandBook.Data
{
    public static class DbInitializer
    {
        public static void Seed(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager )
        {
            if( !roleManager.RoleExistsAsync("Admin").Result )
            {
                roleManager.CreateAsync(new IdentityRole
                {
                    Name = "Admin"
                }).GetAwaiter().GetResult();
            }
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                roleManager.CreateAsync(new IdentityRole
                {
                    Name = "User"
                }).GetAwaiter().GetResult();
            }
            string adminEmail = "jatinAdmin@gmail.com";
            var adminUser = userManager.FindByEmailAsync(adminEmail).GetAwaiter().GetResult();
            if(adminUser == null) // admin does not exists
            {
                var user = new IdentityUser { UserName = adminEmail, Email = adminEmail };
                var result = userManager.CreateAsync(user, "Abcd@123").GetAwaiter().GetResult();
                userManager.AddToRoleAsync(user, "Admin").GetAwaiter().GetResult();
                /*adminUser = userManager.FindByEmailAsync(adminEmail).GetAwaiter().GetResult();
                adminUser.EmailConfirmed = true;
                adminUser.*/
            }
        }
    }
}
