using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
//using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTraining.DAL.Common;
using System.Net.Http.Headers;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeTraining.DAL
{
    public class EnrollmentDAL : IEnrollmentDAL
    {
        public  const string INSERT_ENROLLMENT_QUERY = @"
                                                        INSERT INTO [dbo].[Enrollment]
                                                           ([UserID]
                                                           ,[TrainingID]
                                                           ,[EnrollmentDate]
                                                           ,[EnrollmentStatus])
                                                     VALUES
                                                           (@UserID
                                                           ,@TrainingID
                                                           ,@EnrollmentDate
                                                           ,@EnrollmentStatus) ";

        public const string GET_ALL_ENROLLMENT_QUERY = @"SELECT  * FROM [dbo].[Enrollment]";

        private readonly IDBCommand _dbCommand;

        public EnrollmentDAL(IDBCommand dbCommand)
        {
            _dbCommand = dbCommand;

        }

        public void Add(EnrollmentModel enrollment)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();


            parameters.Add(new SqlParameter("@UserID", enrollment.UserID));
            parameters.Add(new SqlParameter("@TrainingID", enrollment.TrainingID));
            parameters.Add(new SqlParameter("@EnrollmentDate", enrollment.EnrollmentDate));
            parameters.Add(new SqlParameter("@EnrollmentStatus", enrollment.EnrollmentStatus));


            _dbCommand.InsertUpdateData(INSERT_ENROLLMENT_QUERY, parameters);

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EnrollmentModel> GetAll()
        {
            List<EnrollmentModel> enrollments = new List<EnrollmentModel>();

            EnrollmentModel enrollment;
            var dt = _dbCommand.GetData(GET_ALL_ENROLLMENT_QUERY);
            foreach (DataRow row in dt.Rows)
            {
                enrollment = new EnrollmentModel();
                enrollment.UserID = int.Parse(row["UserID"].ToString());
                enrollment.TrainingID = int.Parse(row["TrainingID"].ToString());
                enrollment.EnrollmentDate = (DateTime)row["EnrollmentDate"];
                enrollment.EnrollmentStatus = row["EnrollmentStatus"].ToString();


                enrollments.Add(enrollment);
            }

            return enrollments;
        }

        public EnrollmentModel GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(EnrollmentModel enrollment)
        {
            throw new NotImplementedException();
        }
        public String retrieve() {
            string query = @"SELECT * FROM visitor";
            var dt = _dbCommand.GetData(query);

            var temp = 0;
            return "";
        }
    }
}
