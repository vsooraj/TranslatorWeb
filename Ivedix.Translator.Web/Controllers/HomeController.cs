using Microsoft.AspNetCore.Mvc;

namespace Ivedix.Translator.Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Title = "Welcome to Mi-Translator";

            return View();
        }
    }
}