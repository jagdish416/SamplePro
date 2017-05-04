using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD.Models;
using PagedList;
using PagedList.Mvc;

namespace MVC_CRUD.Controllers
{
    public class tbl_PatientInfoController : Controller
    {
        private PatientDBEntities1 db = new PatientDBEntities1();

        // GET: tbl_PatientInfo
        public ActionResult Index(string search)
        {
            return View(db.tbl_PatientInfo.Where(e => e.Name.StartsWith(search) || search == null).ToList());
        }

        // GET: tbl_PatientInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_PatientInfo tbl_PatientInfo = db.tbl_PatientInfo.Find(id);
            if (tbl_PatientInfo == null)
            {
                return HttpNotFound();
            }
            return View(tbl_PatientInfo);
        }

        // GET: tbl_PatientInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_PatientInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "patid,Name,Address")] tbl_PatientInfo tbl_PatientInfo)
        {
            if (ModelState.IsValid)
            {
                db.tbl_PatientInfo.Add(tbl_PatientInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_PatientInfo);
        }

        // GET: tbl_PatientInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_PatientInfo tbl_PatientInfo = db.tbl_PatientInfo.Find(id);
            if (tbl_PatientInfo == null)
            {
                return HttpNotFound();
            }
            return View(tbl_PatientInfo);
        }

        // POST: tbl_PatientInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "patid,Name,Address")] tbl_PatientInfo tbl_PatientInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_PatientInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_PatientInfo);
        }

        // GET: tbl_PatientInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_PatientInfo tbl_PatientInfo = db.tbl_PatientInfo.Find(id);
            if (tbl_PatientInfo == null)
            {
                return HttpNotFound();
            }
            return View(tbl_PatientInfo);
        }

        // POST: tbl_PatientInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_PatientInfo tbl_PatientInfo = db.tbl_PatientInfo.Find(id);
            db.tbl_PatientInfo.Remove(tbl_PatientInfo);
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
