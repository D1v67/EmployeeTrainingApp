using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Services
{
    public class EnrollmentService : IEnrollmentService
    {

        private readonly IEnrollmentDAL _enrollmentDAL;

        public EnrollmentService(IEnrollmentDAL enrollmentDAL)
        {
            _enrollmentDAL = enrollmentDAL;
        }
        public void Add(Enrollment training)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Enrollment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Enrollment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Enrollment enrollment)
        {
            throw new NotImplementedException();
        }
    }
}
