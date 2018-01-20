using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        [Required(ErrorMessage = "Address is mandatory")]
        public string StreetAddress { get; set; }
        [Required(ErrorMessage = "Phone Number is mandatory")]
        public int PhoneNumber { get; set; }
        public string HomePage { get; set; }
    }
}
