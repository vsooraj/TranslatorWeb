using Ivedix.Translator.Web.Data;
using Ivedix.Translator.Web.Models;
using Ivedix.Translator.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ivedix.Translator.Web.Controllers
{
    public class FileGroupController : Controller
    {
        private readonly AppDbContext _context;

        public FileGroupController(AppDbContext context)
        {
            _context = context;
        }
        // GET: FileGroup
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to Mi-Translator";
            var filegroups = _context.Filegroups.ToList();
            var filegroupViewModel = new FilegroupViewModel()
            {
                Title = "Filegroup",
                Filegroups = filegroups
            };
            return View(filegroupViewModel);
        }

        // GET: FileGroup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FileGroup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FileGroup/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Filegroup model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Filegroups.Add(model);
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

        // GET: FileGroup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FileGroup/Edit/5
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

        // GET: FileGroup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FileGroup/Delete/5
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