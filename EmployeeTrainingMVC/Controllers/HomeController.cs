using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeTraining.DAL;
using EmployeeTraining.DAL.Common;
namespace EmployeeTrainingMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DAL dal = new DAL();
            EnrollmentDAL registration = new EnrollmentDAL();
            registration.retrieve();


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}