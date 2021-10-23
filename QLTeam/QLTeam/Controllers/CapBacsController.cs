using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLTeam.DAL;
using QLTeam.Models;

namespace QLTeam.Controllers
{
    public class CapBacsController : Controller
    {
        private QLTeamContext db = new QLTeamContext();

        // GET: CapBacs
        public ActionResult Index()
        {
            return View(db.CapBacs.ToList());
        }

        // GET: CapBacs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapBac capBac = db.CapBacs.Find(id);
            if (capBac == null)
            {
                return HttpNotFound();
            }
            return View(capBac);
        }

        // GET: CapBacs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapBacs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CapBacID,CapBacCode,CapBacName,MoTa,CreatedBy,CreatedTime,UpdatedBy,UpdatedTime")] CapBac capBac)
        {
            if (ModelState.IsValid)
            {
                db.CapBacs.Add(capBac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(capBac);
        }

        // GET: CapBacs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapBac capBac = db.CapBacs.Find(id);
            if (capBac == null)
            {
                return HttpNotFound();
            }
            return View(capBac);
        }

        // POST: CapBacs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CapBacID,CapBacCode,CapBacName,MoTa,CreatedBy,CreatedTime,UpdatedBy,UpdatedTime")] CapBac capBac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(capBac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(capBac);
        }

        // GET: CapBacs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapBac capBac = db.CapBacs.Find(id);
            if (capBac == null)
            {
                return HttpNotFound();
            }
            return View(capBac);
        }

        // POST: CapBacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CapBac capBac = db.CapBacs.Find(id);
            db.CapBacs.Remove(capBac);
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
