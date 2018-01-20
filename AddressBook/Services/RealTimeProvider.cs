using AddressBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    public class RealTimeProvider : ItimeProvider
    {
        public DateTime Now { get => DateTime.Now; set => throw new NotImplementedException(); }
    }
}
