﻿using Ivedix.Translator.Web.Data;
using Ivedix.Translator.Web.Data.Repositories;
using Ivedix.Translator.Web.Models;
using Ivedix.Translator.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ivedix.Translator.Web.Controllers
{
    [Authorize]
    public class PlatformController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IPlatformRepository _platformRepository;

        public PlatformController(AppDbContext context, IPlatformRepository platformRepository)
        {
            _context = context;
            _platformRepository = platformRepository;
        }
        // GET: Key
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to Mi-Translator";
            //var platforms = _platformRepository.GetAllPlatforms().OrderByDescending(p => p.Name);
            var platforms = _context.Platforms.ToList();
            var platformViewModel = new PlatformViewModel()
            {
                Title = "Platform",
                Platforms = platforms
            };
            return View(platformViewModel);
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
                if (ModelState.IsValid)
                {
                    //_platformRepository.AddPlatform(model);
                    _context.Platforms.Add(model);
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