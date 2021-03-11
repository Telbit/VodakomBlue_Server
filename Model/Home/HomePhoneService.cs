using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Home
{
    public class HomePhoneService : HomeService
    {
        [Required(ErrorMessage = "Phone is required")]
        public HomePhone Phone { get; set; }
    }
}
