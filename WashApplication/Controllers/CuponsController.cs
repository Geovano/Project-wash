using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WashApplication.Context;
using WashApplication.Models;

namespace WashApplication.Controllers
{
    public class CuponsController : Controller
    {
        private AcessoContext db = new AcessoContext();

        // GET: Cupons
        public ActionResult Index()
        {
            return View(db.cupons.ToList());
        }

        // GET: Cupons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cupons cupons = db.cupons.Find(id);
            if (cupons == null)
            {
                return HttpNotFound();
            }
            return View(cupons);
        }

        // GET: Cupons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cupons/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Quantidade,Valor,Codigo")] Cupons cupons)
        {
            if (ModelState.IsValid)
            {
                db.cupons.Add(cupons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cupons);
        }

        // GET: Cupons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cupons cupons = db.cupons.Find(id);
            if (cupons == null)
            {
                return HttpNotFound();
            }
            return View(cupons);
        }

        // POST: Cupons/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Quantidade,Valor,Codigo")] Cupons cupons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cupons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cupons);
        }

        // GET: Cupons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cupons cupons = db.cupons.Find(id);
            if (cupons == null)
            {
                return HttpNotFound();
            }
            return View(cupons);
        }

        // POST: Cupons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cupons cupons = db.cupons.Find(id);
            db.cupons.Remove(cupons);
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
