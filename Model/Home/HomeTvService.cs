using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Home
{
    public class HomeTvService : HomeService
    {
        [Required(ErrorMessage = "Tv is required")]
        public HomeTV Tv { get; set; }
    }
}
