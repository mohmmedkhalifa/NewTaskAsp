using System;

namespace NewTask2
{
  public  enum Jop
    {
        Engineer,
        Doctor,
        Teacher,
        Driver
    }


    public class PersonInfo
    {
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public Jop Jop { get; set; }
        public int PersonId { get; set; }

        public PersonInfo()
        {
        }

        public PersonInfo(int age, DateTime birthday, Jop jop, int personId)
        {
            Age = age;
            Birthday = birthday;
            Jop = jop;
            PersonId = personId;
        }
    }
}
