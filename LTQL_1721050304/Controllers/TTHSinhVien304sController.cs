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
    public class TTHSinhVien304sController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: TTHSinhVien304s
        public ActionResult Index()
        {
            var tTHSinhVien304s = db.TTHSinhVien304s.Include(t => t.LopHoc304s);
            return View(tTHSinhVien304s.ToList());
        }

        // GET: TTHSinhVien304s/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTHSinhVien304 tTHSinhVien304 = db.TTHSinhVien304s.Find(id);
            if (tTHSinhVien304 == null)
            {
                return HttpNotFound();
            }
            return View(tTHSinhVien304);
        }

        // GET: TTHSinhVien304s/Create
        public ActionResult Create()
        {
            ViewBag.MaLop = new SelectList(db.LopHoc304s, "Malop", "TenLop");
            return View();
        }

        // POST: TTHSinhVien304s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSinhVien,HoTen,MaLop")] TTHSinhVien304 tTHSinhVien304)
        {
            if (ModelState.IsValid)
            {
                db.TTHSinhVien304s.Add(tTHSinhVien304);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLop = new SelectList(db.LopHoc304s, "Malop", "TenLop", tTHSinhVien304.MaLop);
            return View(tTHSinhVien304);
        }

        // GET: TTHSinhVien304s/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTHSinhVien304 tTHSinhVien304 = db.TTHSinhVien304s.Find(id);
            if (tTHSinhVien304 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLop = new SelectList(db.LopHoc304s, "Malop", "TenLop", tTHSinhVien304.MaLop);
            return View(tTHSinhVien304);
        }

        // POST: TTHSinhVien304s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSinhVien,HoTen,MaLop")] TTHSinhVien304 tTHSinhVien304)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tTHSinhVien304).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLop = new SelectList(db.LopHoc304s, "Malop", "TenLop", tTHSinhVien304.MaLop);
            return View(tTHSinhVien304);
        }

        // GET: TTHSinhVien304s/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TTHSinhVien304 tTHSinhVien304 = db.TTHSinhVien304s.Find(id);
            if (tTHSinhVien304 == null)
            {
                return HttpNotFound();
            }
            return View(tTHSinhVien304);
        }

        // POST: TTHSinhVien304s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TTHSinhVien304 tTHSinhVien304 = db.TTHSinhVien304s.Find(id);
            db.TTHSinhVien304s.Remove(tTHSinhVien304);
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
