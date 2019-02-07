using MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    public class ObjectRepo
    {
        public void Add(Person person)
        {
            var last = People.PeopleList.LastOrDefault();

            if (last != null)
            {
                person.ID = last.ID + 1;
                
            }

            else
            {
                person.ID = 1;
                
            }

            People.PeopleList.Add(person);
        }

        public Person GetFirstPerson()
        {

            var query = from p in People.PeopleList
                        select p;

            return query.FirstOrDefault();


           //return People.PeopleList.FirstOrDefault();

        }

        public Person GetPerson(int id)

        {
            //var query = from p in People.PeopleList
            //            where p.ID == id
            //            select p;


            //  return query.FirstOrDefault();


            return (from p in People.PeopleList
                        where p.ID == id
                        select p).FirstOrDefault();


          


        }

    }
}
