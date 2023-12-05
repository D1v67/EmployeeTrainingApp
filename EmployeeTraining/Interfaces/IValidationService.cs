using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    internal interface IValidationService
    {
        bool IsEmailExist(string email);
        bool IsNICExist(string nic);
        bool IsMobileNumberExist(string phone);
    }
}
