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
    public class Customer : User
    {
        [Required(ErrorMessage = "Adresses is required")]
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public List<Address> Adresses { get; set; }
        public List<Contract> Contracts { get; set; }
        public List<MobileService> MobileServices { get; set; }
        public List<HomeInternetService> HomeInternetServices { get; set; }
        public List<HomePhoneService> HomePhoneServices { get; set; }
        public List<HomeTvService> HomeTvServices { get; set; }
    }
}
