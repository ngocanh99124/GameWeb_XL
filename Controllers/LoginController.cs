using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameWeb_XL.Models;
using System.Web.Security;
using GameWeb_XL.Controllers.DbModules;

namespace GameWeb_XL.Controllers
{
    
    public class LoginController : Controller
    {
        private Model2 context = new Model2();
        // GET: Login
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        // GET:signup
        public ActionResult Signup()
        {
            ViewBag.Mess = "ok";
            return View();
        }

        [AllowAnonymous]
        // GET:signup
        public ActionResult login()
        {
            ViewBag.Mess = "ok";
            return View();
        }
        //login.html
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult login(LoginModel model)
        {

            var result = LoginModel.login(model.Ten, model.MatKhau);
            if (result && ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.Ten, false);
                return View("../Home/AuthorHome", model);
            }
            else
            {
                ModelState.AddModelError("", "User name or pass word is error?");
            }
            return View();
        }
        //game
        [Authorize]
        public ActionResult Game()
        {
            return View();
        }
        //ds ban be
        public ActionResult DanhSach()
        {
            var model = context.NguoiChois.ToList();
            return View(model);

        }
        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // Post: Login/Create
        [HttpPost]
        public ActionResult Create(string username, string password1)
        {
            var model = new NguoiChoi();
            model.CapDo = 0;
            model.Ten = username;
            model.MatKhau = password1;
            ViewBag.Mess = null;
            if (DbModules.DbNguoiChoi.isExist(model.Ten))
            {
                string a = "ID existed!";
                ViewBag.Mess = a;
                var mo = 1;
                return View("Signup", mo);
            }
            else
            {
                DbModules.DbNguoiChoi.add(model);
                return View("login");
            }

        }


        [Authorize]

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        [Authorize]

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

        [Authorize]
        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [Authorize]

        public ActionResult CreateID()
        {
            var model = new NguoiChoi();
            model.CapDo = 0;
            model.Ten = Request.Form["username"].ToString();
            model.MatKhau = Request.Form["password1"].ToString();
            return Content(model.Ten);
        }

        // POST: Login/Delete/5
        [HttpPost]
        [Authorize]

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
