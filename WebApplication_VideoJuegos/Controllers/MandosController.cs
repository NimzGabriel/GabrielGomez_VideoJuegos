using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_VideoJuegos.Models;

namespace WebApplication_VideoJuegos.Controllers
{
    public class MandosController : Controller
    {
        Model_DB db = new Model_DB();

        // GET: Mandos
        public ActionResult Index()
        {
            return View(db.mandos);
        }

        // GET: Mandos/Details/5
        public ActionResult Details(int id)
        {
            return View(db.mandos.Find(id));
        }

        // GET: Mandos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mandos/Create
        [HttpPost]
        public ActionResult Create(mando new_mando)
        {
            try
            {
                // TODO: Add insert logic here
                db.mandos.Add(new_mando);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.mandos.Find(id));
        }

        // POST: Mandos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, mando mando_edit)
        {
            try
            {
                // TODO: Add update logic here
                mando mando = db.mandos.Find(id);
                mando.marca = mando_edit.marca;
                mando.modelo = mando_edit.modelo;
                mando.precio = mando_edit.precio;
                mando.stock = mando_edit.stock;
                mando.compatibilidad = mando_edit.compatibilidad;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.mandos.Find(id));
        }

        // POST: Mandos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                mando mando = db.mandos.Find(id);
                db.mandos.Remove(mando);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
