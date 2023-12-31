﻿using EmployeeTraining.DAL;
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
    public class TrainingController : Controller
    {
        private readonly ITrainingService _trainingService;
        public TrainingController(ITrainingService trainingService)
        {
            _trainingService = trainingService;
        }
        //GET ALL TRAINING
        public ActionResult Index()
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
            return View(trainings);
        }
        // GET: Training/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: Training/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Training/Create
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

        // GET: Training/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Training/Edit/5
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

        // GET: Training/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Training/Delete/5
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
//public ActionResult Index()

//{

//    TrainingModel model = new TrainingModel() { TrainingName="SQL",TrainingDescription="gsgsg",RegistrationDeadline= new DateTime(2023,12,12) , Capacity=10,DepartmentID=1};
//    try
//    {
//        IEnumerable<TrainingModel> trainings = new List<TrainingModel>();
//        trainings = _trainingService.GetAll();

//        //_trainingService.GetByID(1);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }

//    return View();
//}