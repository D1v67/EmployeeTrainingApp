using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    public interface IEnrollmentService
    {
        IEnumerable<Enrollment> GetAll();
        Enrollment GetByID(int id);
        void Add(Enrollment enrollment);
        void Delete(int id);
        void Update(Enrollment enrollment);
    }
}
