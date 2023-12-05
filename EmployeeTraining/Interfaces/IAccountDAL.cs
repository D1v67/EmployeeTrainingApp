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
    public interface IAccountDAL
    {
          bool IsUserAuthenticated(AccountModel model);
          AccountModel GetUserDetailsWithRoles(AccountModel model);
          void Register(RegisterViewModel model);
    }
}
