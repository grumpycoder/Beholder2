using System.Linq;
using Domain;
using Domain.Identity;
using Domain.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Web
{
    public static class SeedData
    {
        public static void Init()
        {
            using (var db = new AppContext())
            {
                if (!db.Users.Any())
                {
                    var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));

                    manager.Create(new ApplicationUser()
                    {
                        Email = "admin@splcenter.org",
                        UserName = "admin"
                    }, "admin");

                    manager.Create(new ApplicationUser()
                    {
                        Email = "mark.lawrence@splcenter.org", UserName = "mark.lawrence"
                    }, "pass");

                }
            }
        }
    }
}