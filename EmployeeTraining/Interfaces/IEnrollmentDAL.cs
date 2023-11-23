using EmployeeTraining.DAL;
using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    public interface IEnrollmentDAL
    {
        IEnumerable<Enrollment> GetAll();
        Enrollment GetByID(int id);
        void Add(Enrollment enrollment);
        void Delete(int id);
        void Update(Enrollment enrollment);
    }
}
