using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlxBg.Models
{
    public static class SeedAdmin
    {
        private const string DefaultAdminPassword = "123456789Aa!";
        private const string adminEmail = "admin@abv.bg";
        private const string AdminConst = "Admin";
        private static readonly IdentityRole[] roles =
        {
            new IdentityRole(AdminConst),
        };

        public static async void SeedDatabaseAsync(
            this IApplicationBuilder app)
        {
            var serviceFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            var scope = serviceFactory.CreateScope();

            using (scope)
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role.Name))
                    {
                        await roleManager.CreateAsync(role);
                    }
                }

                var user = await userManager.FindByNameAsync(adminEmail);
                if (user == null)
                {
                    user = new IdentityUser()
                    {
                        UserName = adminEmail,
                        Email = adminEmail
                    };

                    var result = await userManager.CreateAsync(user, DefaultAdminPassword);

                    result = await userManager.AddToRoleAsync(user, roles[0].Name);
                }
            }
        }
    }
}
