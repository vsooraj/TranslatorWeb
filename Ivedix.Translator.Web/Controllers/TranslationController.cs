using Ivedix.Translator.Web.Data;
using Ivedix.Translator.Web.Models;
using Ivedix.Translator.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ivedix.Translator.Web.Controllers
{

    public class TranslationController : Controller
    {
        private readonly AppDbContext _context;

        public TranslationController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Key
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to Mi-Translator";
            var translations = _context.Translations.ToList();
            var translationViewModel = new TranslationViewModel()
            {
                Title = "Translation",
                Translations = translations
            };
            return View(translationViewModel);
        }

        // GET: Log/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Log/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Log/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Translation model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Translations.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            catch
            {
                return View();
            }
        }
    }
}
