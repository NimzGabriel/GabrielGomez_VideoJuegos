using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_VideoJuegos.Models;

namespace WebApplication_VideoJuegos.Controllers
{
    public class JuegosController : Controller
    {
        Model_DB db = new Model_DB();

        // GET: Juegos
        public ActionResult Index()
        {
            return View(db.juegos);
        }

        // GET: Juegos/Details/5
        public ActionResult Details(int id)
        {
            return View(db.juegos.Find(id));
        }

        // GET: Juegos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juegos/Create
        [HttpPost]
        public ActionResult Create(juego new_juego)
        {
            try
            {
                // TODO: Add insert logic here
                db.juegos.Add(new_juego);

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.juegos.Find(id));
        }

        // POST: Juegos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, juego juego_edit)
        {
            try
            {
                // TODO: Add update logic here
                juego juego = db.juegos.Find(id);
                juego.anio = juego_edit.anio;
                juego.nombre = juego_edit.nombre;
                juego.plataforma = juego_edit.plataforma;
                juego.precio = juego_edit.precio;
                juego.restriccion = juego_edit.restriccion;
                juego.stock = juego_edit.stock;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.juegos.Find(id));
        }

        // POST: Juegos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                juego juego = db.juegos.Find(id);
                db.juegos.Remove(juego);

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
