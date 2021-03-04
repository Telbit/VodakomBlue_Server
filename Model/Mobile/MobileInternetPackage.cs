using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Mobile
{
    public class MobileInternetPackage
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Size is required (but it doesn't matter ;) )")]
        public int Size { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Start time is required")]
        public DateTime StartDate { get; set; }

        [ForeignKey("Id")]
        public MobileService MobileService { get; set; }
        


    }
}
