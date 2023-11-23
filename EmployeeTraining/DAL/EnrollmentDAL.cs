using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
//using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTraining.DAL.Common;

namespace EmployeeTraining.DAL
{
    public class EnrollmentDAL : IEnrollmentDAL
    {

        public void Add(Enrollment enrollment)
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
        public String retrieve() {
            string query = @"SELECT * FROM visitor";
            var dt = DbCommand.GetData(query);

            var temp = 0;
            return "";
        }
    }
}
