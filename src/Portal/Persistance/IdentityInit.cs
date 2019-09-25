//using Microsoft.AspNetCore.Identity;
//using Portal.Domain.Entities;
//using System;
//using System.Threading.Tasks;

//namespace Portal.Persistance
//{
//    public class IdentityInit
//    {

//        public async Task SeedUsers(UserManager<ApplicationUser> userManager)
//        {
           
//            }

//        }

//        public async Task SeedRoles(RoleManager<IdentityRole> roleManager)
//        {
           

//            if (!roleManager.RoleExistsAsync("Agent").Result)
//            {
//                var role = new IdentityRole
//                {
//                    Name = "Agent"
//                };

//                await roleManager.CreateAsync(role);
//            }


//            if (!roleManager.RoleExistsAsync("Member").Result)
//            {
//                var role = new IdentityRole
//                {
//                    Name = "Member"
//                };

//                await roleManager.CreateAsync(role);
//            }

//            return;
//        }
//    }
//}
