using System.Web.Helpers;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using AutoMapper;
using Domain.Identity;
using Microsoft.AspNet.Identity;
using Web.Models;

namespace Web.Controllers
{

    public class ProfileController : BaseController
    {
        private readonly ApplicationUserManager _userManager;

        public ProfileController(ApplicationUserManager userManager)
        {
            _userManager = userManager;
        }

        public ActionResult Index()
        {
            var model = Mapper.Map<ProfileForm>(_userManager.FindById(User.Identity.GetUserId()));
            return View(model);
        }

        public JsonResult Update(ProfileForm form)
        {
            var user = _userManager.FindById(User.Identity.GetUserId());
            user.Email = form.EmailAddress;
            user.UserName = form.Username;
            user.FullName = form.FullName; 
            _userManager.Update(user);

            return Json(true);
        }
    }

}