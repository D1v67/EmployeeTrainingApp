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
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        private readonly ILoginService _loginService;

        public LoginController(IUserService userService, ILoginService userDAL, ILoginService loginService)
        {
            _userService=userService;
            _loginService= loginService;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Authenticate(LoginModel model)
        {
            //LoginModel model = new LoginModel() { Email= "john.doe@example.com", Password= "adminpassword"};

            bool IsUserValid = _loginService.AuthenticateUser(model);

            //return IsUserValid;

            if (IsUserValid)
            {
                LoginModel userInfo = _loginService.GetUserDetailsWithRoles(model);
                this.Session["CurrentUser"] = userInfo;
                this.Session["CurrentRole"] = userInfo.RoleName;

            }

            return Json(new { result = IsUserValid, url = Url.Action("Index", "Home") });
        }

        //[HttpPost]
        public ActionResult Register()
        {
            //return RedirectToAction("Index", "Home");
            return View();
        }
        [HttpPost]
        public JsonResult Register(RegisterViewModel model)
        {
            RegisterViewModel registerViewModel = model;
            //return RedirectToAction("Index", "Home");
            //_userService.Add(userModel);
            //_loginService.AddAccount(loginModel);
            _loginService.RegisterUser(model);

            return Json(new { url = Url.Action("Index", "Home") });
        }
        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
