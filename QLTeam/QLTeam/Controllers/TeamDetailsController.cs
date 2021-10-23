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
    public class TeamDetailsController : Controller
    {
        private QLTeamContext db = new QLTeamContext();

        // GET: TeamDetails
        public ActionResult Index(int? id)
        {
            var list = StoreGetTeamDetail(id);

            return View(list);
        }
        public List<TeamDetail> StoreGetTeamDetail(int? teamId)
        {
            List<TeamDetail> result = new List<TeamDetail>();
            var clientIdParameter = new SqlParameter("@TeamId", teamId);
            result = db.Database
                    .SqlQuery<TeamDetail>("GetTeamDetail @TeamId", clientIdParameter)
                    .ToList();
            return result;
        }
        // GET: TeamDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamDetail teamDetail = db.TeamDetails.Find(id);
            if (teamDetail == null)
            {
                return HttpNotFound();
            }
            return View(teamDetail);
        }

        // GET: TeamDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TeamDetailID,TeamID,NhomQuyenID,ChucVuCode,ChucVuName,NhanVienID,CreatedBy,CreatedTime,UpdatedBy,UpdatedTime")] TeamDetail teamDetail)
        {
            if (ModelState.IsValid)
            {
                db.TeamDetails.Add(teamDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teamDetail);
        }

        // GET: TeamDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamDetail teamDetail = db.TeamDetails.Find(id);
            if (teamDetail == null)
            {
                return HttpNotFound();
            }
            return View(teamDetail);
        }

        // POST: TeamDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TeamDetailID,TeamID,NhomQuyenID,ChucVuCode,ChucVuName,NhanVienID,CreatedBy,CreatedTime,UpdatedBy,UpdatedTime")] TeamDetail teamDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teamDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teamDetail);
        }

        // GET: TeamDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamDetail teamDetail = db.TeamDetails.Find(id);
            if (teamDetail == null)
            {
                return HttpNotFound();
            }
            return View(teamDetail);
        }

        // POST: TeamDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeamDetail teamDetail = db.TeamDetails.Find(id);
            db.TeamDetails.Remove(teamDetail);
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
