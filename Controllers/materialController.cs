using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using annorum_supra_18dec.Models;

namespace annorum_supra_18dec.Controllers
{
    public class materialController : Controller
    {
        private annorum_supra_cmps411Entities db = new annorum_supra_cmps411Entities();

        // GET: material
        public ActionResult Index()
        {          
            annorum_supra_cmps411Entities entities = new annorum_supra_cmps411Entities();
            List<tbl_common_mtrl> material = entities.tbl_common_mtrl.ToList();

            ViewBag.type = new SelectList(db.tbl_common_mtrl, "type", "type");
            ViewBag.subtype = new SelectList(db.tbl_common_mtrl, "subtype", "subtype");

            return View(db.tbl_common_mtrl.ToList());
        }

        // GET: material/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_common_mtrl tbl_common_mtrl = db.tbl_common_mtrl.Find(id);
            if (tbl_common_mtrl == null)
            {
                return HttpNotFound();
            }
            return View(tbl_common_mtrl);
        }

        // GET: material/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: material/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,type,subtype")] tbl_common_mtrl tbl_common_mtrl)
        {
            if (ModelState.IsValid)
            {
                db.tbl_common_mtrl.Add(tbl_common_mtrl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_common_mtrl);
        }

        // GET: material/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_common_mtrl tbl_common_mtrl = db.tbl_common_mtrl.Find(id);
            if (tbl_common_mtrl == null)
            {
                return HttpNotFound();
            }
            return View(tbl_common_mtrl);
        }

        // POST: material/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,type,subtype")] tbl_common_mtrl tbl_common_mtrl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_common_mtrl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_common_mtrl);
        }

        // GET: material/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_common_mtrl tbl_common_mtrl = db.tbl_common_mtrl.Find(id);
            if (tbl_common_mtrl == null)
            {
                return HttpNotFound();
            }
            return View(tbl_common_mtrl);
        }

        // POST: material/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tbl_common_mtrl tbl_common_mtrl = db.tbl_common_mtrl.Find(id);
            db.tbl_common_mtrl.Remove(tbl_common_mtrl);
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
