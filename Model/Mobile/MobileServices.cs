using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public class MobileServices
    {
        [Key]
        public int Id { get; }

        [Required(ErrorMessage = "Phone number is required")]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        public int MobilePackage { get; set; }

        [Required(ErrorMessage = "MobileInternet is required")]
        public int MobileInternet { get; set; }

        [Required(ErrorMessage = "UserId is required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "ContractId is required")]
        public int ContractId { get; set; }

    }
}
