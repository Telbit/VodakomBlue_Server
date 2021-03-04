using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public class MobilePhonePackage
    {
        [Key]
        public int Id { get; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "TalkMinute is required")]
        public int FreeMinutes { get; set; }

        [Required(ErrorMessage = "FreeSms is required")]
        public int FreeSms { get; set; }

        [Required(ErrorMessage = "TotalPrice is required")]
        public int TotalPrice { get; set; }

        [Required(ErrorMessage = "MinuteFee is required")]
        public int MinuteFee { get; set; }

        [Required(ErrorMessage = "InsideNetwork is required")]
        public int InsideNetwork { get; set; }

        [Required(ErrorMessage = "OutsideNetwork is required")]
        public int OutsideNetwork { get; set; }

        
    }
}
