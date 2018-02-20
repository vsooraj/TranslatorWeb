using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Ivedix.Translator.Web.Controllers
{
    public class AdminController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        
    }
}