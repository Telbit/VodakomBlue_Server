using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public abstract class Package
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        [Column(TypeName = "decimal")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Date is Required")]
        public DateTime ReleaseDate { get; set; }
    }
}
