using Paymentauthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paymentauthorization.Controllers
{
    public class provincesController : Controller
    {
        Admin_DBEntities db = new Admin_DBEntities();
        // GET: provinces
        public ActionResult Index()
        {
            return View(db.Provinces.ToList());
        }

        [HttpPost]
        public ActionResult Index(Province province)
        {
            db.Provinces.Add(province);
            db.SaveChanges();

            return View(db.Provinces.ToList());
        }
        // GET: provinces/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: provinces/Create
        public ActionResult Create()
        {
            Admin_DBEntities db = new Admin_DBEntities();
            var pro=db.Provinces.ToList();
            
            return View();
        }

        // POST: provinces/Create
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

        // GET: provinces/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: provinces/Edit/5
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

        // GET: provinces/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: provinces/Delete/5
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
