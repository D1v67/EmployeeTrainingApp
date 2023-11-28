using EmployeeTraining.DAL;
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
    public class LoginService: ILoginService
    {
        private readonly IUserDAL _userDAL;
        private readonly ILoginDAL _loginDAL;

        public LoginService(IUserDAL userDAL, ILoginDAL loginDAL)
        {
            _userDAL= userDAL;
            _loginDAL= loginDAL;
        }
        public  bool AuthenticateUser(LoginModel model)
        {
            return _loginDAL.AuthenticateUser(model);

        }

        public  LoginModel GetUserDetailsWithRoles(LoginModel model)
        {
            return _loginDAL.GetUserDetailsWithRoles(model);

        }

        public void RegisterUser(RegisterViewModel model)
        {
            _loginDAL.Register(model);

        }
    }
}
