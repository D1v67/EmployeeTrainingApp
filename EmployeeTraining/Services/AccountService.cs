﻿using EmployeeTraining.DAL;
using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using EmployeeTraining.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserDAL _userDAL;
        private readonly IAccountDAL _loginDAL;

        public AccountService(IUserDAL userDAL, IAccountDAL loginDAL)
        {
            _userDAL = userDAL;
            _loginDAL = loginDAL;
        }
        public bool IsUserAuthenticated(AccountModel model)
        {
                return _loginDAL.IsUserAuthenticated(model);
        }

        public AccountModel GetUserDetailsWithRoles(AccountModel model)
        {
            return _loginDAL.GetUserDetailsWithRoles(model);
        }

        public void RegisterUser(RegisterViewModel model)
        {
            _loginDAL.Register(model);
        }
    }
}
