using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Emanager.Core;
using Emanager.Web.Infrastructure;

namespace Emanager.Web.Controllers
{
    public class HomeController : Controller
    {
        private IDepartmentDataSource _db;

        //just want the home controller to only know about IDepartmentDataSource
        //so that the home controllers knows nothing about department dbs 
        public HomeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allDepartments = _db.Departments;

            return View(allDepartments);
        }

        //needs to be updated with form for user to reply with about them when logged in
        //have ko bind the results as the user types in their infromation
        public ActionResult About()
        {
            ViewBag.Message = "Let's make it easier!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our info:";

            return View();
        }
    }
}
