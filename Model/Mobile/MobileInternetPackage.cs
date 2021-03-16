using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Mobile
{
    public class MobileInternetPackage : Package
    {
        
        [Required(ErrorMessage = "Size is required (but it doesn't matter ;) )")]
        public int Size { get; set; }

    }
}
