using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    public interface ITrainingDAL
    {
        IEnumerable<Training> GetAll();
        Training GetByID(int id);
        void Add(Training training);
        void Delete(int id);
        void Update(Training training);

    }
}
