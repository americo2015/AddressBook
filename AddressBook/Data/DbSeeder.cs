using AddressBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Data
{
    public class DbSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Person.Any())
                {
                    return;
                }

                context.Person.AddRange(
                    new Person
                    {
                        FirstName = "Americo",
                        LastName = "Perez",
                        CityOfBirth = "Santiago"
                    },
                    new Person
                    {
                        FirstName = "Alberto",
                        LastName = "Casas",
                        CityOfBirth = "Sundsvall"
                    },
                    new Person
                    {
                        FirstName = "Soledad",
                        LastName = "Valdes",
                        CityOfBirth = "Valparaiso"
                    }
                );

                context.SaveChanges();

                if (context.Address.Any())
                {
                    return;
                }

                context.Address.AddRange(
                    new Address
                    {
                        StreetAddress = "Bjursätragatan",
                        PhoneNumber = 0760474712,
                        HomePage = ""
                    },
                    new Address
                    {
                        StreetAddress = "Street Name",
                        PhoneNumber = 826257,
                        HomePage = "http://gooogle.com"
                    },
                    new Address
                    {
                        StreetAddress = "Arica",
                        PhoneNumber = 626257398,
                        HomePage = ""
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
