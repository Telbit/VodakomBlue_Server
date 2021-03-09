using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Home
{
    public abstract class HomeService : Service
    {
        [Required(ErrorMessage = "Address is required")]
        public Address Address { get; set; }
    }
}
