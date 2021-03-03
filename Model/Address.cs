using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public class Address
    {
        [MaxLength(4)]
        [Required(ErrorMessage = "Zip is required")]
        public int ZipCode { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Address is required")]
        public string StreetAddress { get; set; }

        [Required]
        public bool IsBillingAddress { get; set; }
    }
}
