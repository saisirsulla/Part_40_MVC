using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Part40Mvc.Models;

namespace Part40Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Details(int id)
        {
            SampleDBContext db = new SampleDBContext();
            Employee employees = db.Employees.Single(x => x.Id == id);         
            return View(employees);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            SampleDBContext db = new SampleDBContext();
            Employee employees = db.Employees.Single(x => x.Id == id);
            return View(employees);
        }

        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }
    }
}