using Ivedix.Translator.Web.Data;
using Ivedix.Translator.Web.Models;
using Ivedix.Translator.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ivedix.Translator.Web.Controllers
{
    public class LogController : Controller
    {
        private readonly AppDbContext _context;

        public LogController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Key
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to Mi-Translator";
            var logs = _context.Logs.ToList();
            var logViewModel = new LogViewModel()
            {
                Title = "Log",
                Logs = logs
            };
            return View(logViewModel);
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
        public ActionResult Create(Log model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Logs.Add(model);
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

        // GET: Log/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Log/Edit/5
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

        // GET: Log/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Log/Delete/5
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