using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLTeam.DAL;
using QLTeam.Models;

namespace QLTeam.Controllers
{
    public class LichSuCongTacsController : Controller
    {
        private QLTeamContext db = new QLTeamContext();

        // GET: LichSuCongTacs
        public ActionResult Index()
        {
            
            var clientIdParameter = new SqlParameter("@TeamId", 4);
            var clientIdParameter2 = new SqlParameter("@Teamcode", "ABC");
            var result = db.Database
                    .SqlQuery<Team>("GetTeam @TeamId,@Teamcode", clientIdParameter, clientIdParameter2)
                    .ToList();
            
            return View(db.LichSuCongTacs.ToList());
        }

        // GET: LichSuCongTacs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichSuCongTac lichSuCongTac = db.LichSuCongTacs.Find(id);
            if (lichSuCongTac == null)
            {
                return HttpNotFound();
            }
            return View(lichSuCongTac);
        }

        // GET: LichSuCongTacs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LichSuCongTacs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LichSuCongTacID,NhanVienID,TeamID,ChucVuCode,CongTyID,ThoiGianBatDau,ThoiGianketThuc,CreatedBy,CreatedTime,UpdatedBy,UpdatedTime")] LichSuCongTac lichSuCongTac)
        {
            if (ModelState.IsValid)
            {
                db.LichSuCongTacs.Add(lichSuCongTac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lichSuCongTac);
        }

        // GET: LichSuCongTacs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichSuCongTac lichSuCongTac = db.LichSuCongTacs.Find(id);
            if (lichSuCongTac == null)
            {
                return HttpNotFound();
            }
            return View(lichSuCongTac);
        }

        // POST: LichSuCongTacs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LichSuCongTacID,NhanVienID,TeamID,ChucVuCode,CongTyID,ThoiGianBatDau,ThoiGianketThuc,CreatedBy,CreatedTime,UpdatedBy,UpdatedTime")] LichSuCongTac lichSuCongTac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lichSuCongTac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lichSuCongTac);
        }

        // GET: LichSuCongTacs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichSuCongTac lichSuCongTac = db.LichSuCongTacs.Find(id);
            if (lichSuCongTac == null)
            {
                return HttpNotFound();
            }
            return View(lichSuCongTac);
        }

        // POST: LichSuCongTacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LichSuCongTac lichSuCongTac = db.LichSuCongTacs.Find(id);
            db.LichSuCongTacs.Remove(lichSuCongTac);
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
