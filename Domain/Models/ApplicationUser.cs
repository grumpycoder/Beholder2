using Domain.Models.Enums;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Domain.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ApplicationUser()
        {
        }

        public ApplicationUser(string username) : base(username)
        {
        }

        public SecurityLevel SecurityLevel { get; set; }

        public string FullName { get; set; }

    }
}