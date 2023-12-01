using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeTraining.DAL;
using EmployeeTraining.DAL.Common;
using EmployeeTraining.Interfaces;

namespace EmployeeTrainingMVC.Controllers
{
    public class HomeController : Controller
    {
       // private readonly Test_IDataAccessLayer _layer;

        public HomeController()
        {
            
        }
        public ActionResult Index()
        {


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