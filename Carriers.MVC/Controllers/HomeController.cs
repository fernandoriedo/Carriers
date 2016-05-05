using System.Web.Mvc;
using Carriers.Application.Interfaces;

namespace Carriers.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserAppService _userApp;

        public HomeController(IUserAppService userApp)
        {
            _userApp = userApp;
        }
        public ActionResult Index()
        {
            ViewBag.UserId = new SelectList(_userApp.GetAll(), "UserId", "Name");

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}