using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Home
{
    public class HomeInternet
    {
        [Key]
        public int Id { get; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "DownloadSpeed is Required")]
        public int DownloadSpeed { get; set; }

        [Required(ErrorMessage = "UploadSpeed is Required")]
        public int UploadSpeed { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        public decimal Price { get; set; }

        [MaxLength(10)]
        [Required(ErrorMessage = "Technology is Required")]
        public string Technology { get; set; }

        [Required(ErrorMessage = "Date is Required")]
        public DateTime Date { get; set; }
    }
}
