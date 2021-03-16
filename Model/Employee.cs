using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public class Employee : User
    {
        public Address Address { get; set; }
        public EmployeeType EmployeeType { get; set; } 
    }
}
