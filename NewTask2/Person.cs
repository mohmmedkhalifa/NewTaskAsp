using System;
namespace NewTask2
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public Person()
        {

        }

        public Person(int iD, string name, string password, string email, string phone)
        {
            ID = iD;
            Name = name;
            Password = password;
            Email = email;
            Phone = phone;
        }
    }
}
