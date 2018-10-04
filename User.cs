using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public User()
        {

        }

        private static int id = 0;

        public string FirstName
        {
            get;
            set;
        }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int Id { get; private set; }
        public string phone { get; set; }


        public void Input()
        {
            Console.WriteLine("Name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Surname");
            LastName = Console.ReadLine();
            Console.WriteLine("Password");
            Password = Console.ReadLine();
            Console.WriteLine("Phone");
            Password = Console.ReadLine();
            Id = id++;
        }
        public void View()
        {

            Console.WriteLine("Name");
            Console.WriteLine(FirstName);

            Console.WriteLine("Surname");
            Console.WriteLine(LastName);

            Console.WriteLine("Password");
            Console.WriteLine(Password);

            Console.WriteLine("Id");
            Console.WriteLine(Id);

        }
    }
}
