using Ivedix.Translator.Web.Data;
using Ivedix.Translator.Web.Data.Repositories;
using Ivedix.Translator.Web.Models;
using Ivedix.Translator.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ivedix.Translator.Web.Controllers
{
    public class LanguagesController : Controller
    {
        private readonly AppDbContext _context;
        private ILanguageRepository _languageRepository;

        public LanguagesController(AppDbContext context, ILanguageRepository languageRepository)
        {
            _context = context;
            _languageRepository = languageRepository;

        }
        // GET: Languages
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to Mi-Translator";
            //var languages = _languageRepository.GetAllLanguages().OrderByDescending(p => p.Name);
            var languages = _context.Languages.ToList();
            var languageViewModel = new LanguageViewModel()
            {
                Title = "Language",
                Languages = languages
            };
            return View(languageViewModel);
        }

        // GET: Languages/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Languages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Languages/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Language language)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Languages.Add(language);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(language);
            }
            catch
            {
                return View();
            }
        }

        // GET: Languages/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Languages/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Languages/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Languages/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}