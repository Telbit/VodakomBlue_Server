using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Zip is required")]
        public int ZipCode { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Address is required")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "IsBillingAddress is required")]
        public bool IsBillingAddress { get; set; }

        [Required(ErrorMessage = "IsHomeAddress is required")]
        public bool IsHomeAddress { get; set; }

        /*[ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("Customer")]*/
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }

        
    }
}
