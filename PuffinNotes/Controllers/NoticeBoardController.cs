using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PuffinNotes.Models;

namespace PuffinNotes.Controllers
{
    public class NoticeBoardController : Controller
    {
        private NoticeBoardDBContext db = new NoticeBoardDBContext();

        //
        // GET: /NoticeBoard/

        public ActionResult Index()
        {
            ViewBag.title = "List Noticeboards";
            return View(db.NoticeBoards.ToList());
        }

        //
        // GET: /NoticeBoard/Details/5

        public ActionResult Details(int id = 0)
        {
            ViewBag.title = "Noticeboard Details"; 
            NoticeBoard noticeboard = db.NoticeBoards.Find(id);
            if (noticeboard == null)
            {
                return HttpNotFound();
            }
            return View(noticeboard);
        }

     

        //
        // GET: /NoticeBoard/Create

        public ActionResult Create()
        {
            ViewBag.title = "Create Noticeboard";
            return View();
        }

        //
        // POST: /NoticeBoard/Create

        [HttpPost]
        public ActionResult Create(NoticeBoard noticeboard)
        {
            if (ModelState.IsValid)
            {
                ViewBag.title = "Create Noticeboard";
                db.NoticeBoards.Add(noticeboard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(noticeboard);
        }

        //
        // GET: /NoticeBoard/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ViewBag.title = "Edit Noticeboard"; 
            NoticeBoard noticeboard = db.NoticeBoards.Find(id);
            if (noticeboard == null)
            {
                return HttpNotFound();
            }
            return View(noticeboard);
        }

        //
        // POST: /NoticeBoard/Edit/5

        [HttpPost]
        public ActionResult Edit(NoticeBoard noticeboard)
        {
            if (ModelState.IsValid)
            {
                ViewBag.title = "Edit Noticeboard";
                db.Entry(noticeboard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(noticeboard);
        }

        //
        // GET: /NoticeBoard/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ViewBag.title = "Delete Noticeboard";
            NoticeBoard noticeboard = db.NoticeBoards.Find(id);
            if (noticeboard == null)
            {
                return HttpNotFound();
            }
            return View(noticeboard);
        }

        //
        // POST: /NoticeBoard/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ViewBag.title = "Delete Noticeboard";
            NoticeBoard noticeboard = db.NoticeBoards.Find(id);
            db.NoticeBoards.Remove(noticeboard);
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