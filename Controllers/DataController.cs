﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eventStoreASP.Controllers
{
    public class DataController : Controller
    {
        // GET: DataController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DataController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DataController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DataController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DataController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DataController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DataController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DataController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
