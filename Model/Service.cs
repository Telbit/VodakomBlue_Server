using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public abstract class Service
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "User is required")]
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "Contract is required")]
        public Contract Contract { get; set; }
    }
}
