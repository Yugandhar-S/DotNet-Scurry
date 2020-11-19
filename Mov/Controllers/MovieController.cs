using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mov.Models;

namespace Mov.Controllers
{
    public class MovieController : Controller
    {
        private MovieEntity db = new MovieEntity();

        //
        // GET: /Movie/

        public ActionResult Index()
        {
            return View(db.MovieDBs.ToList());
        }

        //
        // GET: /Movie/Details/5

        public ActionResult Details(int id = 0)
        {
            MovieDB moviedb = db.MovieDBs.Find(id);
            if (moviedb == null)
            {
                return HttpNotFound();
            }
            return View(moviedb);
        }

        //
        // GET: /Movie/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Movie/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieDB moviedb)
        {
            if (ModelState.IsValid)
            {
                db.MovieDBs.Add(moviedb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(moviedb);
        }

        //
        // GET: /Movie/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MovieDB moviedb = db.MovieDBs.Find(id);
            if (moviedb == null)
            {
                return HttpNotFound();
            }
            return View(moviedb);
        }

        //
        // POST: /Movie/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MovieDB moviedb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moviedb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(moviedb);
        }

        //
        // GET: /Movie/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MovieDB moviedb = db.MovieDBs.Find(id);
            if (moviedb == null)
            {
                return HttpNotFound();
            }
            return View(moviedb);
        }

        //
        // POST: /Movie/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieDB moviedb = db.MovieDBs.Find(id);
            db.MovieDBs.Remove(moviedb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}