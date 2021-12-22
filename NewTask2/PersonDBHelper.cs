using System;
using System.Collections.Generic;
using System.Linq;
using static NewTask2.InfoOfPerson;



namespace NewTask2
{
    public class PersonDBHelper
    {
        List<Person> persons = new List<Person>();
        List<PersonInfo> personInfos = new List<PersonInfo>();

        public void AddPerson(Person person)
        {
            Person x = persons.Where(e => e.ID == person.ID).FirstOrDefault();
            if (x == null)
            {

                persons.Add(person);

            }
            else
            {
                Console.WriteLine("This Person is Exists");
            }

        }

        public void AddInfo(PersonInfo info)
        {
            var y = persons.Where(e => e.ID == info.PersonId).FirstOrDefault();
            var x = personInfos.Where(e => e.PersonId == info.PersonId).FirstOrDefault();
            if (y != null && x == null)
            {
                personInfos.Add(info);

            }
            else { Console.WriteLine("This Info is Exists for This Person"); }
        }

        public void joinList()
        {
            var x = persons.Join(personInfos, e => e.ID, a => a.PersonId, (e, a) => new PersonWithInfo
            {
                Name = e.Name,
                Password = e.Password,
                Email = e.Email,
                Phone = e.Phone,
                Age = a.Age,
                Birthday = a.Age,
                Jop = a.Jop,
            }).ToList();

            var d = x.GroupBy(e => e.Jop ).Select(e=> new {
                Name = e.Key,

                Count = e.Count()
            });
            foreach (var e in d)
            {
                Console.WriteLine(e.Name + " " + e.Count);
            }
        }

        public PersonDBHelper()
        {

        }


    }


}
