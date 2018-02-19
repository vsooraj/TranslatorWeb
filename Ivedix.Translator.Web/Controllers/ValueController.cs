using Ivedix.Translator.Web.Data;
using Ivedix.Translator.Web.Models;
using Ivedix.Translator.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ivedix.Translator.Web.Controllers
{
    public class ValueController : Controller
    {
        private readonly AppDbContext _context;

        public ValueController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Key
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to Mi-Translator";
            var values = _context.Platformkeys.ToList();
            var valueViewModel = new ValueViewModel()
            {
                Title = "Value/PlatformKey",
                Platformkeys = values
            };
            return View(valueViewModel);
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
        public ActionResult Create(Platformkey model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Platformkeys.Add(model);
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

        // GET: Value/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Value/Edit/5
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

        // GET: Value/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Value/Delete/5
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