using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Waste_Manager.Models;

namespace Waste_Manager.Controllers
{
    public class Cleanup_providersController : Controller
    {
        private masterEntities3 db = new masterEntities3();

        // GET: Cleanup_providers
        public ActionResult Index()
        {
            return View(db.Cleanup_providers.ToList());
        }

        // GET: Cleanup_providers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cleanup_providers cleanup_providers = db.Cleanup_providers.Find(id);
            if (cleanup_providers == null)
            {
                return HttpNotFound();
            }
            return View(cleanup_providers);
        }

        // GET: Cleanup_providers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cleanup_providers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cleanid,Companyname,locality")] Cleanup_providers cleanup_providers)
        {
            if (ModelState.IsValid)
            {
                db.Cleanup_providers.Add(cleanup_providers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cleanup_providers);
        }

        // GET: Cleanup_providers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cleanup_providers cleanup_providers = db.Cleanup_providers.Find(id);
            if (cleanup_providers == null)
            {
                return HttpNotFound();
            }
            return View(cleanup_providers);
        }

        // POST: Cleanup_providers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cleanid,Companyname,locality")] Cleanup_providers cleanup_providers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cleanup_providers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cleanup_providers);
        }

        // GET: Cleanup_providers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cleanup_providers cleanup_providers = db.Cleanup_providers.Find(id);
            if (cleanup_providers == null)
            {
                return HttpNotFound();
            }
            return View(cleanup_providers);
        }

        // POST: Cleanup_providers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cleanup_providers cleanup_providers = db.Cleanup_providers.Find(id);
            db.Cleanup_providers.Remove(cleanup_providers);
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
