using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SubjectController : Controller
    {
        private WebApp.Models.WebAppModel db = new Models.WebAppModel();
        // GET: Subject
        public ActionResult Index()
        {
            return View(db.Subject.ToList());
        }
        public ActionResult Create()
        {
            ViewData["TeachersList"] = db.Teacchers.Select(p => new SelectListItem() { Text = p.TeachersName, Value = p.id.ToString() }).AsEnumerable();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Subject  model)
        {
            if (ModelState.IsValid)
            {
                db.Subject.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}