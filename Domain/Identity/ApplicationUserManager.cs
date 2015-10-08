using Domain.Models;
using Microsoft.AspNet.Identity;

namespace Domain.Identity
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {

        public ApplicationUserManager(IUserStore<ApplicationUser> store): base(store)
        {
            UserValidator = new UserValidator<ApplicationUser>(this)
            {
                AllowOnlyAlphanumericUserNames = false, 
                RequireUniqueEmail = true,
            };
            PasswordValidator = new PasswordValidator()
            {
                RequireDigit = false,
                RequireNonLetterOrDigit = false,
                RequireUppercase = false, 
                RequiredLength = 3
            };
        }

    }
}