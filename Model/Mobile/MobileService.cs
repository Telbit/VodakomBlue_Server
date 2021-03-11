using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Mobile
{
    public class MobileService
    {
        [Key]
        public int Id { get; }

        [Required(ErrorMessage = "Phone number is required")]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        public int MobilePhonePackageId { get; set; }

        [Required(ErrorMessage = "MobileInternet is required")]
        public int MobileInternetPackageId { get; set; }

        
        [Required(ErrorMessage = "UserId is required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "ContractId is required")]
        public int ContractId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("ContractId")]
        public Contract Contract { get; set; }

        [ForeignKey("MobilePhonePackageId")]
        public MobilePhonePackage MobilePhonePackage { get; set; }

        [ForeignKey("MobileInternetPackageId")]
        public MobileInternetPackage MobileInternetPackage { get; set; }

    }
}
