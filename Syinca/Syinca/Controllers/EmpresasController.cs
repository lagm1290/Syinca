using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Syinca.Models;

namespace Syinca.Controllers
{
    public class EmpresasController : Controller
    {
        private EmpresasContext db = new EmpresasContext();

        // GET: Empresas
        public ActionResult Index()
        {
            var cOM_Empresas = db.COM_Empresas.Include(c => c.COM_Representantes);
            return View(cOM_Empresas.ToList());
        }

        // GET: Empresas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COM_Empresas cOM_Empresas = db.COM_Empresas.Find(id);
            if (cOM_Empresas == null)
            {
                return HttpNotFound();
            }
            return View(cOM_Empresas);
        }

        // GET: Empresas/Create
        public ActionResult Create()
        {
            ViewBag.Representante = new SelectList(db.COM_Representantes, "Id", "Identificacion");
            return View();
        }

        // POST: Empresas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nit,RazonSocial,NombreComercial,Representante,JfeRecursos,Ciudad,Direccion,TelefonoFijo,NroCelular,Email,NroEmpleados,Latitud,Longitud,Zona")] COM_Empresas cOM_Empresas)
        {
            if (ModelState.IsValid)
            {
                db.COM_Empresas.Add(cOM_Empresas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Representante = new SelectList(db.COM_Representantes, "Id", "Identificacion", cOM_Empresas.Representante);
            return View(cOM_Empresas);
        }

        // GET: Empresas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COM_Empresas cOM_Empresas = db.COM_Empresas.Find(id);
            if (cOM_Empresas == null)
            {
                return HttpNotFound();
            }
            ViewBag.Representante = new SelectList(db.COM_Representantes, "Id", "Identificacion", cOM_Empresas.Representante);
            return View(cOM_Empresas);
        }

        // POST: Empresas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nit,RazonSocial,NombreComercial,Representante,JfeRecursos,Ciudad,Direccion,TelefonoFijo,NroCelular,Email,NroEmpleados,Latitud,Longitud,Zona")] COM_Empresas cOM_Empresas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cOM_Empresas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Representante = new SelectList(db.COM_Representantes, "Id", "Identificacion", cOM_Empresas.Representante);
            return View(cOM_Empresas);
        }

        // GET: Empresas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COM_Empresas cOM_Empresas = db.COM_Empresas.Find(id);
            if (cOM_Empresas == null)
            {
                return HttpNotFound();
            }
            return View(cOM_Empresas);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            COM_Empresas cOM_Empresas = db.COM_Empresas.Find(id);
            db.COM_Empresas.Remove(cOM_Empresas);
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
