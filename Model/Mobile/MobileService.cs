using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Mobile
{
    public class MobileService : Service
    {

        [Required(ErrorMessage = "Phone number is required")]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        public MobilePhonePackage MobilePhonePackage { get; set; }

        [Required(ErrorMessage = "Mobile Internet Package is required")]
        public MobileInternetPackage MobileInternetPackage { get; set; }

    }
}
