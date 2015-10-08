using System.Web.Mvc;
using Domain;

namespace Web.Controllers
{
    public class BaseController: Controller
    {
        public readonly AppContext db;

        public BaseController()
        {
            db = new AppContext();
        }
    }
}