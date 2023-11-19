using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Entities
{
    public class Training
    {
        private int TrainingID { get; set; }
        private string TrainingName { get; set; }
        private string TrainingDescription { get; set; }
        private DateTime RegistrationDeadline { get; set; }
        private int DepartmentID { get; set; }

    }
}
