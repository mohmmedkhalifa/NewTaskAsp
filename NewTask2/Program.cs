using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace NewTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDBHelper dBHelper = new PersonDBHelper();
            Person fPerson = new Person(1, "Mohammed Khalifa", "123456", "moh.khalifa04@gmail.com", "0597915437");
            Person sPerson = new Person(2, "Ahmed Naser", "123456", "moh.khalifa04@gmail.com", "0597915437");
            Person tPerson = new Person(3, "Jihad Mansour", "123456", "moh.khalifa04@gmail.com", "0597915437");
            Person foPerson = new Person(4, "Eesaa Njjar", "123456", "moh.khalifa04@gmail.com", "0597915437");
            Person ffPerson = new Person(5, "Adam Abu Ziad", "123456", "moh.khalifa04@gmail.com", "0597915437");
            Person siPerson = new Person(6, "Hala Saad", "123456", "moh.khalifa04@gmail.com", "0597915437");
            Person sePerson = new Person(7, "Lara Shek", "123456", "moh.khalifa04@gmail.com", "0597915437");
            Person ePerson = new Person(8, "Haya Mousa", "123456", "moh.khalifa04@gmail.com", "0597915437");
            PersonInfo fPersonInfo = new PersonInfo(25, DateTime.Now, Jop.Engineer, 1);
            PersonInfo sPersonInfo = new PersonInfo(27, DateTime.Now, Jop.Doctor, 2);
            PersonInfo tPersonInfo = new PersonInfo(27, DateTime.Now, Jop.Engineer, 3);
            PersonInfo foPersonInfo = new PersonInfo(27, DateTime.Now, Jop.Engineer, 4);
            PersonInfo ffPersonInfo = new PersonInfo(27, DateTime.Now, Jop.Teacher, 5);
            PersonInfo siPersonInfo = new PersonInfo(27, DateTime.Now, Jop.Driver, 6);
            PersonInfo sePersonInfo = new PersonInfo(27, DateTime.Now, Jop.Doctor, 7);
            PersonInfo ePersonInfo = new PersonInfo(27, DateTime.Now, Jop.Doctor, 8);

            dBHelper.AddPerson(fPerson);
            dBHelper.AddPerson(sPerson);
            dBHelper.AddPerson(tPerson);
            dBHelper.AddPerson(foPerson);
            dBHelper.AddPerson(ffPerson);
            dBHelper.AddPerson(siPerson);
            dBHelper.AddPerson(sePerson);
            dBHelper.AddPerson(ePerson);
            dBHelper.AddInfo(fPersonInfo);
            dBHelper.AddInfo(sPersonInfo);
            dBHelper.AddInfo(tPersonInfo);
            dBHelper.AddInfo(foPersonInfo);
            dBHelper.AddInfo(ffPersonInfo);
            dBHelper.AddInfo(siPersonInfo);
            dBHelper.AddInfo(sePersonInfo);
            dBHelper.AddInfo(ePersonInfo);
            dBHelper.joinList();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>

             Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });

    }
}
