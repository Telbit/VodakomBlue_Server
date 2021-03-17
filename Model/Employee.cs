using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public class Employee : User
    {
        [Required(ErrorMessage = "Adresses is required")]
        public Address Address { get; set; }
        [Required(ErrorMessage = "Employee position is required")]
        public EmployeeType EmployeeType { get; set; } 
    }
}
