using HospitalMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Doctors()
        {
            return RedirectToAction("Index", "Doctors");
        }

        public ActionResult Patients()
        {
            return RedirectToAction("Index", "Patients");
        }

        public ActionResult Visits()
        {
            return RedirectToAction("Index", "Visits");
        }
    }
}