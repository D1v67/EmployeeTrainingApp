using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.DAL
{
    public class TrainingDAL : ITrainingDAL
    {
        public const string GetAllTrainingQuery = @"SELECT  FROM [dbo].[Training]";

        public const string GetTrainingByIdQuery = @"";

        public const string InsertTrainingQuery = @"";

        public const string UpdateTrainingQuery = @"";

        public const string DeleteTrainingQuery = @"";
        public IEnumerable<Training> GetAll()
        {
            throw new NotImplementedException();
        }

        public Training GetByID(int id)
        {
            throw new NotImplementedException();
        }
        public void Add(Training training)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Training training)
        {
            throw new NotImplementedException();
        }
    }
}
