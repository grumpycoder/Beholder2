using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Domain;
using Domain.Identity;
using Domain.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Web.Models;

namespace Web.Controllers
{
    [System.Web.Http.AllowAnonymous]
    public class AuthenticationController: BaseController
    {
        private readonly ApplicationUserManager _userManager;
        private readonly IAuthenticationManager _authManager;

        public AuthenticationController(ApplicationUserManager userManager, IAuthenticationManager authManager)
        {
            _userManager = userManager;
            _authManager = authManager;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginForm form)
        {
            var user = await _userManager.FindByNameAsync(form.Username);
            if (user == null || !(await _userManager.CheckPasswordAsync(user, form.Password)))
            {
                Response.StatusCode = 400;
                return Json("The username or password is invalid.");
            }

            var identity = _userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

            _authManager.SignIn(new AuthenticationProperties {IsPersistent = false}, identity);

            return Json(true);
        }

    }
}