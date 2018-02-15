using Ivedix.Translator.Web.Data.Repositories;
using Ivedix.Translator.Web.Models;
using Ivedix.Translator.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ivedix.Translator.Web.Controllers
{
    public class PlatformController : Controller
    {
        private readonly IPlatformRepository _platformRepository;

        public PlatformController(IPlatformRepository platformRepository)
        {
            _platformRepository = platformRepository;
        }
        // GET: Platform
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to Mi-Translator";
            var platforms = _platformRepository.GetAllPlatforms().OrderByDescending(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Platform",
                Platforms = platforms.ToList()
            };
            return View(homeViewModel);
        }

        // GET: Platform/Details/5
        public IActionResult Details(int id)
        {
            var platform = _platformRepository.GetPlatformById(id);
            if (platform == null) return NotFound();
            return View(platform);
        }

        // GET: Platform/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Platform/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Platform model)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest();
                // TODO: Add insert logic here
                _platformRepository.AddPlatform(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Platform/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Platform/Edit/5
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

        // GET: Platform/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Platform/Delete/5
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