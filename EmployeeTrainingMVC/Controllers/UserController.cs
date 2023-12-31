﻿using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using EmployeeTraining.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EmployeeTrainingMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService = userService;
        }
        public ActionResult Index()
        {
            IEnumerable<UserModel> users = new List<UserModel>();
            try
            {
                users = _userService.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(users);
        }

        public JsonResult GetManagers()
        {
            IEnumerable<UserModel> managers = _userService.GetAllManager();
            return Json(managers, JsonRequestBehavior.AllowGet);
        }
        //TODO
        // GET: UserDefault/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserDefault/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: UserDefault/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserDefault/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserDefault/Edit/5
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

        // GET: UserDefault/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserDefault/Delete/5
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


// GET: UserDefault
//public ActionResult Index()
//{
//    //UserModel user = new UserModel() {FirstName= "Divesh", LastName="Nugesur",Email="eee@mail.com",NIC ="NSSS11",MobileNumber="32321312", RoleID = 3, DepartmentID= 2, ManagerID= 2};

//    //IEnumerable<UserModel> users = new List<UserModel>();
//    //try
//    //{

//    //    users = _userService.GetAll();


//    //}
//    //catch (Exception ex)
//    //{
//    //    Console.WriteLine(ex.Message);
//    //}
//    try
//    {
//        IEnumerable<UserModel> users = new List<UserModel>();
//        //users = _userService.GetAll();

//        users = _userService.GetAll();
//        //UserModel user = new UserModel();

//        //_userService.Add(user);

//        //_userService.Delete(6);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);

//    }

//    return View(users);
//}
