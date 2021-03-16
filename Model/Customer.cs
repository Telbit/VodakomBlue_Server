using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public class Customer : User
    {
        [Required(ErrorMessage = "Adresses is required")]
        public List<Address> Adresses { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}
