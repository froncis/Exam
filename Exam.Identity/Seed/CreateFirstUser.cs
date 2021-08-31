using Exam.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Exam.Identity.Seed
{
    public static class CreateFirstUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var applicationUser = new ApplicationUser
            {
                FirstName = "user1",
                LastName = "user1",
                UserName = "userTest1",
                Email = "userTest1@user.com",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(applicationUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(applicationUser, "Plural&01?");
            }
        }
    }
}
