using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using EmployeeTraining.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeTrainingMVC.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly IEnrollmentService _enrollmentService;
        private readonly ITrainingService _trainingService;

        public EnrollmentController(IEnrollmentService enrollmentService, ITrainingService trainingService)
        {
            _enrollmentService = enrollmentService;
            _trainingService = trainingService;
        }
        // GET: Enrollment
        //GET ALL TRAINING
        public ActionResult Index()
        {

            IEnumerable<EnrollmentModel> enrollments = new List<EnrollmentModel>();
            try
            {
                enrollments = _enrollmentService.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(enrollments);
        }

        public JsonResult ViewTrainingData()
        {

            IEnumerable<TrainingModel> trainings = new List<TrainingModel>();
            try
            {
                trainings = _trainingService.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Json(trainings, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveEnroll(EnrollmentModel model)
        {
            EnrollmentModel enrollment = model;
            try
            { Console.WriteLine("Enrolled");
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
   
                return Json(new { success = false, error = ex.Message });
            }
        }

        public ActionResult ViewTraining()
        {
            return View();
        }



        // GET: Enrollment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Enrollment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enrollment/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Enrollment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Enrollment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Enrollment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Enrollment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
