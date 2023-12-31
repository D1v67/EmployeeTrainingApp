﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Entities
{
    public class AccountModel
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Enter Email please")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
    }
}
