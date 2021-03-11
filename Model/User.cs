using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Model
{
    public class User
    {
        [Key]
        public int Id { get; }

        [Required(ErrorMessage = "First name is required")]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Adresses is required")]
        public List<Address> Adresses { get; set; }

        [MaxLength(30)]
        [Required(ErrorMessage = "Id Card Number is required")]
        public string IdCardNumber { get; set; }

        [MaxLength(60)]
        [Required(ErrorMessage = "Mother's name is required")]
        public string MothersName { get; set; }

        [Required(ErrorMessage = "Birth date is required")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Birth date is required")]
        [MaxLength(12), MinLength(11)]
        public string ContactPhoneNumber { get; set; }

        public List<Contract> Contracts { get; set; }
    }
}
