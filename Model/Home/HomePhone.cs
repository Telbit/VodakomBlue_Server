using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Home
{
    public class HomePhone
    {
        [Key]
        public int Id { get; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "TalkMinutes is Required")]
        public int TalkMinutes { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Date is Required")]
        public DateTime Date { get; set; }
    }
}
