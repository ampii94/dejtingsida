using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using WebApplication2.Models;
using DataLayer.Repositories;

namespace WebApplication2.Controllers
{
    public class SearchController : Controller
    {
        private DejtDbContext context = new DejtDbContext();
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(SearchModel model)
        {
            using (var userRep = new UserRepository(context))
            {
                model.Result = userRep.getUsersByName(model.SearcgString);
                model.SignedInUser = User.Identity.Name;
            }
            return View(model);
        }
    }
}