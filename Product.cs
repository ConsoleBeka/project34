using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {


        public Product()
        {
        }


        public int Price { get; set; }
        public string Name { get; set; }

        public void Input(string name,int price)
        {
            Console.WriteLine("Price");
            Price = price;
            Console.WriteLine("Name");
            Name = name;

        }
        public void Input1()
        {
            
            Console.WriteLine("Name");
            Name = Console.ReadLine(); ;
            Console.WriteLine("Price");
            Price = Console.Read(); ;
        }
        public void View()
        {
            Console.WriteLine(" Price:");
            Console.WriteLine(Price);

            Console.WriteLine(" Name:");
            Console.WriteLine(Name);
            Console.WriteLine(" ");


        }

    }
}
