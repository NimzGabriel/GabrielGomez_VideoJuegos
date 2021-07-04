using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_VideoJuegos.Models;

namespace WebApplication_VideoJuegos.Controllers
{
    public class ConsolasController : Controller
    {
        Model_DB db = new Model_DB();

        // GET: Consolas
        public ActionResult Index()
        {
            return View(db.consolas);
        }

        // GET: Consolas/Details/5
        public ActionResult Details(int id)
        {
            return View(db.consolas.Find(id));
        }

        // GET: Consolas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consolas/Create
        [HttpPost]
        public ActionResult Create(consola new_consola)
        {
            try
            {
                // TODO: Add insert logic here
                db.consolas.Add(new_consola);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.consolas.Find(id));
        }

        // POST: Consolas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, consola consola_edit)
        {
            try
            {
                // TODO: Add update logic here
                consola consola = db.consolas.Find(id);
                consola.anio = consola_edit.anio;
                consola.marca = consola_edit.marca;
                consola.modelo = consola_edit.modelo;
                consola.nueva = consola_edit.nueva;
                consola.precio = consola_edit.precio;
                consola.stock = consola_edit.stock;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.consolas.Find(id));
        }

        // POST: Consolas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                consola consola = db.consolas.Find(id);
                db.consolas.Remove(consola);

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
