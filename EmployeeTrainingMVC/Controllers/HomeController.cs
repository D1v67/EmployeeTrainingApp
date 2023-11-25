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
        private readonly IDataAccessLayer _layer;

        public HomeController(IDataAccessLayer layer)
        {
            _layer = layer;
        }
        public ActionResult Index()
        {
            //DAL dal = new DAL();
            //EnrollmentDAL registration = new EnrollmentDAL();
            //registration.retrieve();

            //IGenericDAL<User>() userDAL;
            ViewBag.Message = _layer.Connect();
            ViewBag.MyName = "MVC";

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