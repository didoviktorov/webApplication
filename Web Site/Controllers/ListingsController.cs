using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_Site.Models;

namespace Web_Site.Controllers
{
    public class ListingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Listings
        public ActionResult Index()
        {
            return View(db.Listings.Include(p => p.Author).ToList());
        }

        // GET: Listings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Listings listings = db.Listings.Find(id);
            if (listings == null)
            {
                return HttpNotFound();
            }
            return View(listings);
        }

        // GET: Listings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Listings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Body")] Listings listings)
        {
            if (ModelState.IsValid)
            {
                db.Listings.Add(listings);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(listings);
        }

        // GET: Listings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Listings listings = db.Listings.Find(id);
            if (listings == null)
            {
                return HttpNotFound();
            }
            return View(listings);
        }

        // POST: Listings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Body,Date")] Listings listings)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listings).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(listings);
        }

        // GET: Listings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Listings listings = db.Listings.Find(id);
            if (listings == null)
            {
                return HttpNotFound();
            }
            return View(listings);
        }

        // POST: Listings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Listings listings = db.Listings.Find(id);
            db.Listings.Remove(listings);
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
