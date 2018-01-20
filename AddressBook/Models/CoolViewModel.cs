using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class CoolViewModel
    {
       

        [Display(Name = "CoolMessage")]
        public string CoolMessage { get; set; }
    }
}
