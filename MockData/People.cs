using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockData
{
    public class People
    {
        public static List<Person> PeopleList = new List<Person>
        {
            new Person
            {
                ID = 1,
                Name = "Roman",
                LastName = "Kowalski",
                BirthDate = new DateTime(2000,1,1),
                Height = 200,
                Weight = 80
            }   ,

              new Person
            {
                ID = 2,
                Name = "Ala",
                LastName = "Kowalska",
                BirthDate = new DateTime(2001,1,1),
                Height = 160,
                Weight = 80
            },

                new Person
            {
                ID = 3,
                Name = "Ola",
                LastName = "Nowak",
                BirthDate = new DateTime(2002,1,1),
                Height = 170,
                Weight = 80
            }



        };



    }
}
