using EmployeeTraining.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NIC { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public RolesEnum RoleType { get; set; }
        public int ManagerID { get; set; }
        public int DepartmnentID { get; set; }


    }
}
