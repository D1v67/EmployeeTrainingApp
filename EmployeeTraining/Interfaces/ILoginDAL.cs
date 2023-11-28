using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTraining.ViewModel;

namespace EmployeeTraining.Interfaces
{
    public interface ILoginDAL
    {
          bool AuthenticateUser(LoginModel model);
   

          LoginModel GetUserDetailsWithRoles(LoginModel model);
   


          void Register(RegisterViewModel model);

    }
}
