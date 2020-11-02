using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameWeb_XL.Controllers.DbModules;

namespace GameWeb_XL.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        [Authorize]
        public ActionResult Index(string id)
        {
            var model = DbNguoiChoi.get(id);
            return View(model);
        }

        // GET: Detail/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Detail/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Detail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Detail/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Detail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Detail/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
