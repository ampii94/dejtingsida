using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using WebApplication2.Models;
using DataLayer.Repositories;
using System.Web.Security;
using DataLayer.Entities;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private DejtDbContext context = new DejtDbContext();
        public ActionResult Index()
        {
            StartModel model = new StartModel();
            var userRep = new UserRepository(context);
            model.randomUsers = userRep.getFive();
            return View(model);
        }
        private bool CheckPassword(string email, string password)
        {
            var userRep = new UserRepository(context);
            var userToCheck = userRep.GetUser(email);
            if(userToCheck.Password.Equals(password))
            {
                return true;
            }
            return false;
        }

        [HttpPost]
        public ActionResult LogIn(LogInModel model)
        {
            if (!ModelState.IsValid) return View(model); ;
            var Email = model.Email;
            var Password = model.Password;

            using (var userRep = new UserRepository(context))
            {
                if(userRep.UserExists(Email) && CheckPassword(Email , Password))
                {
                    User user = userRep.GetUser(Email);
                }
                else
                {
                    ModelState.AddModelError("", "Email does not exist");
                    return View(model);
                }
            }
            FormsAuthentication.SetAuthCookie(Email, true);
            return RedirectToAction("Profile", "SignedInUser");
        }
       
       
    }
}