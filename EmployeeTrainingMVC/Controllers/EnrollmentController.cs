﻿using EmployeeTraining.Entities;
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
        private readonly IPrerequisiteService _prerequisiteService;
        public EnrollmentController(IEnrollmentService enrollmentService, ITrainingService trainingService, IPrerequisiteService prerequisiteService)
        {
            _enrollmentService = enrollmentService;
            _trainingService = trainingService;
            _prerequisiteService = prerequisiteService;
        }
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

        public ActionResult ViewTraining()
        {
            return View();
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

        public ActionResult EnrollTraining(int trainingID)
        {
            IEnumerable<PrerequisiteModel> prerequisites = new List<PrerequisiteModel>();
        
            prerequisites = _prerequisiteService.GetPrerequisiteByTrainingID(trainingID);
            ViewBag.ListOfPrerequisiteByTrainingID = prerequisites;
            return View();
        }

        [HttpPost]
        public ActionResult SaveEnrollment(EnrollmentModel model)
        {
            //EnrollmentModel enrollment = model;
            try
            {
                _enrollmentService.Add(model);
               // Console.WriteLine("Enrolled");
                return Json(new { success = true, message = "Enrollment successful!" });
            }
            catch (Exception ex)
            {
   
                return Json(new { success = false, error = ex.Message });
            }
        }

        public ActionResult GetPrerequisiteByTrainingID(int TrainigID)
        {
            IEnumerable<PrerequisiteModel> prerequisites = new List<PrerequisiteModel>();
            try
            {
                prerequisites = _prerequisiteService.GetPrerequisiteByTrainingID(TrainigID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Json(prerequisites, JsonRequestBehavior.AllowGet);

        }

        //TODO
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
