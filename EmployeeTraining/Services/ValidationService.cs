using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Services
{
    public class ValidationServices : IValidationService
    {
        private readonly IUserService userService;

        public ValidationServices(IUserService userService)
        {

        }
        public bool IsEmailExist(string email)
        {
            throw new NotImplementedException();
        }

        public bool IsMobileNumberExist(string phone)
        {
            throw new NotImplementedException();
        }

        public bool IsNICExist(string nic)
        {
            throw new NotImplementedException();
        }
    }
}
