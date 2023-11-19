using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Entities
{
    public class Registration
    {
        private string RegistrationId;
        private string ManagerId { get; set; }
        private string DepartmentName { get; set; }

        private List<Registration> ListOfPrerequisites { get; set; }

        //add application

    }
}
