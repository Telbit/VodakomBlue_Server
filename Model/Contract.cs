using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public class Contract
    {
        [Key]
        public int Id { get; }

        [Required(ErrorMessage = "Salesman is required")]
        public Employee Employee { get; set; }

        [Required(ErrorMessage = "Customer is required")]
 
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Atleast one service required")]
        public List<Service> Services { get; set; }
    }
}
