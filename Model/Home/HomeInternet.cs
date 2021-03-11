using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Home
{
    public class HomeInternet : Package
    {
        [Required(ErrorMessage = "DownloadSpeed is Required")]
        public int DownloadSpeed { get; set; }

        [Required(ErrorMessage = "UploadSpeed is Required")]
        public int UploadSpeed { get; set; }

        [MaxLength(10)]
        [Required(ErrorMessage = "Technology is Required")]
        public string Technology { get; set; }
    }
}
