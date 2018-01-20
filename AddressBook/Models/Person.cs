using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        [Required(ErrorMessage = "First name is mandatory")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is mandatory")]
        public string LastName { get; set; }
        [Display(Name = "City of Birth")]
        public string CityOfBirth { get; set; }
    }
}
