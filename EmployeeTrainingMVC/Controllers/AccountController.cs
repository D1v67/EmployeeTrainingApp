using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using EmployeeTraining.Services;
using EmployeeTraining.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.Mvc;

namespace EmployeeTrainingMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IAccountService _loginService;

        public AccountController(IUserService userService, IAccountService loginService)
        {
            _userService=userService;
            _loginService= loginService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Authenticate(AccountModel model)
        {
            bool IsUserValid = _loginService.AuthenticateUser(model);
            //return IsUserValid;
            if (IsUserValid)
            {
                AccountModel userInfo = _loginService.GetUserDetailsWithRoles(model);
                this.Session["UserID"] = userInfo.UserID;
                this.Session["CurrentRole"] = userInfo.RoleName;
                this.Session["Email"] = userInfo.Email;
            }
            return Json(new { result = IsUserValid, url = Url.Action("ViewTraining", "Enrollment") });
        }

        //[HttpPost]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Register(RegisterViewModel model)
        {
            RegisterViewModel registerViewModel = model;
           
            _loginService.RegisterUser(registerViewModel);
             return Json(new { url = Url.Action("Index", "User") });
        }
        // GET: Login/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Login/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Login/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Login/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Login/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Login/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Login/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
