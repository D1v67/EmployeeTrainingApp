using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    internal interface IValidationService
    {
        bool IsEmailValid(string email);
        bool IsNICValid(string nic);
        bool IsPasswordValid(string password);
        bool IsPhoneValid(string phone);
    }
}
