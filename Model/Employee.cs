using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public class Employee : User
    {
        [Required(ErrorMessage = "Adresses is required")]
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        [Required(ErrorMessage = "Employee position is required")]
        public EmployeeType EmployeeType { get; set; } 
    }
}
