using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
namespace WebApp.Controllers
{
    public class NotesController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Notes
        public ActionResult Index()
        {
            return View(db.Notes.ToList());
        }

        public ActionResult CreateNote()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NoteCreate(Note note)
        {
            return View();
        }
    }
}