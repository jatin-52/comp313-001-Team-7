using Microsoft.AspNetCore.Identity;

namespace SecondHandBook.Data
{
    public static class DbInitializer
    {
        public static void Seed(RoleManager<IdentityRole> roleManager )
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
        }
    }
}
