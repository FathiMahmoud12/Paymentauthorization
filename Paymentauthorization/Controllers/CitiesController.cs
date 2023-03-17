using Paymentauthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paymentauthorization.Controllers
{
    public class CitiesController : Controller
    {
        Admin_DBEntities db = new Admin_DBEntities();

        // GET: Cities
        public ActionResult Index()
        {
            var Combo_Provinces = db.Provinces.ToList();

            if (Combo_Provinces != null)
            {
                @ViewBag.data = Combo_Provinces;
            }

            return View(db.Cities.ToList());
        }
        [HttpPost]
        public ActionResult Index(City city)
        {
            db.Cities.Add(city);
            db.SaveChanges();
            return View(db.Cities.ToList());
        }

        // GET: Cities/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cities/Create
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

        // GET: Cities/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cities/Edit/5
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

        // GET: Cities/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cities/Delete/5
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
