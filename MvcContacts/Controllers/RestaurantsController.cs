﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcContacts.Models;

namespace MvcContacts.Controllers
{
    public class RestaurantsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Restaurants
        public ActionResult Index()
        {
            return View(db.Restaurants.ToList());
        }

        // GET: Restaurants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurants restaurants = db.Restaurants.Find(id);
            if (restaurants == null)
            {
                return HttpNotFound();
            }
            return View(restaurants);
        }

        // GET: Restaurants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurants/Create
        // Aktivieren Sie zum Schutz vor übermäßigem Senden von Angriffen die spezifischen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Street,Place,RestaurantClass")] Restaurants restaurants)
        {
            if (ModelState.IsValid)
            {
                db.Restaurants.Add(restaurants);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restaurants);
        }

        // GET: Restaurants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurants restaurants = db.Restaurants.Find(id);
            if (restaurants == null)
            {
                return HttpNotFound();
            }
            return View(restaurants);
        }

        // POST: Restaurants/Edit/5
        // Aktivieren Sie zum Schutz vor übermäßigem Senden von Angriffen die spezifischen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Street,Place,RestaurantClass")] Restaurants restaurants)
        {
            if (ModelState.IsValid)
            {
                db.Entry(restaurants).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurants);
        }

        // GET: Restaurants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurants restaurants = db.Restaurants.Find(id);
            if (restaurants == null)
            {
                return HttpNotFound();
            }
            return View(restaurants);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Restaurants restaurants = db.Restaurants.Find(id);
            db.Restaurants.Remove(restaurants);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
