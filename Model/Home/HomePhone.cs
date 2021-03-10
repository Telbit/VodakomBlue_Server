using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model.Home
{
    public class HomePhone : Package
    {
        [Required(ErrorMessage = "TalkMinutes is Required")]
        public int TalkMinutes { get; set; }
    }
}
