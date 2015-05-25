﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using SAGS.DataContexts;

namespace SAGS.Controllers
{
    public class ScoutersController : Controller
    {
        private ScoutersDb db = new ScoutersDb();

        // GET: /Scouters/
        public ActionResult Index()
        {
            return View(db.Scouters.ToList());
        }

        // GET: /Scouters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Scouter scouter = db.Scouters.Find(id);
            if (scouter == null)
            {
                return HttpNotFound();
            }
            return View(scouter);
        }

        // GET: /Scouters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Scouters/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,Lastname,GenderMember,Address,City,Telephones,EmailAddresses,Document,Identification,WorkExperience")] Scouter scouter)
        {
            if (ModelState.IsValid)
            {
                db.Scouters.Add(scouter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scouter);
        }

        // GET: /Scouters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Scouter scouter = db.Scouters.Find(id);
            if (scouter == null)
            {
                return HttpNotFound();
            }
            return View(scouter);
        }

        // POST: /Scouters/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,Lastname,GenderMember,Address,City,Telephones,EmailAddresses,Document,Identification,WorkExperience")] Scouter scouter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scouter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scouter);
        }

        // GET: /Scouters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Scouter scouter = db.Scouters.Find(id);
            if (scouter == null)
            {
                return HttpNotFound();
            }
            return View(scouter);
        }

        // POST: /Scouters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Scouter scouter = db.Scouters.Find(id);
            db.Scouters.Remove(scouter);
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