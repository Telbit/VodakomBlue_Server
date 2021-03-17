using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model.Mobile;

namespace VodakomBlue.Model
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Salesman is required")]
        public Employee Salesman { get; set; }

        [Required(ErrorMessage = "Customer is required")]
 
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        public List<MobileService> MobileServices { get; set; }
        public List<HomeInternetService> HomeInternetServices { get; set; }
        public List<HomePhoneService> HomePhoneServices { get; set; }
        public List<HomeTvService> HomeTvServices { get; set; }
    }
}
