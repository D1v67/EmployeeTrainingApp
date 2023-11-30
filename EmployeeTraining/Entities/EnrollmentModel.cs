using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Entities
{
    public class EnrollmentModel
    {
        public int EnrollmentID { get; set; }
        public int UserID { get; set; }
        public int TrainingID { get; set; }
        public  DateTime EnrollmentDate { get; set; }

        public string EnrollmentStatus { get; set; }


        //add application

    }
}
