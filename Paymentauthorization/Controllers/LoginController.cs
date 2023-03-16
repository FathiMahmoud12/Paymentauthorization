using Paymentauthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paymentauthorization.Controllers
{
    public class LoginController : Controller
    {
        Admin_DBEntities db = new Admin_DBEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult Index(User u)
        {
            var FindUsername = db.Users.Where(x => x.UserNAme == u.UserNAme && x.Password == u.Password).FirstOrDefault();
            if (FindUsername != null)
            {
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return RedirectToAction("Index", "Login");

            }
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
