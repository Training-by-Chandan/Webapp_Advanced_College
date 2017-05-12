using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        private WebAppModel db = new WebAppModel();
       public ActionResult Register()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Register(UserRegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                //check if user exists
                var tmp = db.Users.Where(p => p.UserName == model.UserName).FirstOrDefault();

                if (tmp==null) //doesnot exists
                {
                    db.Users.Add(model.User);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("UserExists", "User already exists");
                    return View(model);
                }
            }
            return View(model);
        }

        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var tmp = db.Users.Where(p => p.UserName == model.UserName).FirstOrDefault();
               
                //check if user exists
                if (tmp!=null) 
                {
                    //check if password match
                    if (tmp.PasswordHash==model.PasswordHash)
                    {
                        Session.Add("LoggedIn", true);
                        Session.Add("UserName", tmp.UserName);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("PasswordError", "Password not matched.");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("UserExists", "User does not exists");
                    return View(model);
                }
            }

            return View(model);
        }
    }
}