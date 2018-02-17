using Ivedix.Translator.Web.Data;
using Ivedix.Translator.Web.Models;
using Ivedix.Translator.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ivedix.Translator.Web.Controllers
{
    public class KeyController : Controller
    {
        private readonly AppDbContext _context;

        public KeyController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Key
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to Mi-Translator";
            var keys = _context.Keys.ToList();
            var keyViewModel = new KeyViewModel()
            {
                Title = "Key",
                Keys = keys
            };
            return View(keyViewModel);
        }

        // GET: Key/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Key/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Key/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Key model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Keys.Add(model);
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

        // GET: Key/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Key/Edit/5
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

        // GET: Key/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Key/Delete/5
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