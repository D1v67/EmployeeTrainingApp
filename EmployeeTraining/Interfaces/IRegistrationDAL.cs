using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    public interface IRegistrationDAL
    {
        IEnumerable<Registration> GetAll();
        Registration GetByID(int id);
        void Add(Registration registration);
        void Delete(int id);
        void Update(Registration registration);
    }
}
