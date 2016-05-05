using System.Web.Mvc;
using Carriers.Application.Interfaces;

namespace Carriers.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}