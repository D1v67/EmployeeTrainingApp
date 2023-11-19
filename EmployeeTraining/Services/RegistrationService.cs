using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Services
{
    public class RegistrationService : IRegistrationService
    {

        private readonly IRegistrationDAL _registrationDAL;

        public RegistrationService(IRegistrationDAL registrationDAL)
        {
            _registrationDAL = registrationDAL;
        }
        public void Add(Registration training)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Registration> GetAll()
        {
            throw new NotImplementedException();
        }

        public Registration GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Registration training)
        {
            throw new NotImplementedException();
        }
    }
}
