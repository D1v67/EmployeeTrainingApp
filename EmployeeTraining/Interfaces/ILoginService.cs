using EmployeeTraining.DAL;
using EmployeeTraining.Entities;
using EmployeeTraining.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    public interface ILoginService
    {
        bool AuthenticateUser(LoginModel model);


        LoginModel GetUserDetailsWithRoles(LoginModel model);

        void RegisterUser(RegisterViewModel model);

    }
}
