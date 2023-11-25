using EmployeeTraining.DAL;
using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Services
{
    public class LoginService
    {
        public static bool AuthenticateUser(LoginModel model)
        {
            return LoginDAL.AuthenticateUser(model);

        }

        public static LoginModel GetUserDetailsWithRoles(LoginModel model)
        {
            return LoginDAL.GetUserDetailsWithRoles(model);

        }
    }
}
