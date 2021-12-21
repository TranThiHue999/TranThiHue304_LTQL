using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050304.Models;

namespace LTQL_1721050304.Controllers
{
    public class LopHoc304sController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: LopHoc304s
        public ActionResult Index()
        {
            return View(db.LopHoc304s.ToList());
        }

        // GET: LopHoc304s/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc304 lopHoc304 = db.LopHoc304s.Find(id);
            if (lopHoc304 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc304);
        }

        // GET: LopHoc304s/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopHoc304s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Malop,TenLop")] LopHoc304 lopHoc304)
        {
            if (ModelState.IsValid)
            {
                db.LopHoc304s.Add(lopHoc304);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lopHoc304);
        }

        // GET: LopHoc304s/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc304 lopHoc304 = db.LopHoc304s.Find(id);
            if (lopHoc304 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc304);
        }

        // POST: LopHoc304s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Malop,TenLop")] LopHoc304 lopHoc304)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lopHoc304).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lopHoc304);
        }

        // GET: LopHoc304s/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc304 lopHoc304 = db.LopHoc304s.Find(id);
            if (lopHoc304 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc304);
        }

        // POST: LopHoc304s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LopHoc304 lopHoc304 = db.LopHoc304s.Find(id);
            db.LopHoc304s.Remove(lopHoc304);
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
