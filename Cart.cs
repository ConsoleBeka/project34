using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cart
    {


        public Cart()
        {
        }


        public int Price { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }

        public void Input(int price,string name)
        {
            
            Console.WriteLine("Price");
            Price = price;
            Console.WriteLine("Name");
            Name = name;

        }
        int Pricetotal;
        public void View()
        {
            Console.WriteLine("Price");
            Console.WriteLine(Price);

            Console.WriteLine("Name");
            Console.WriteLine(Name);

             Pricetotal=Price +Price;
           
        }
        public void price (){
            Console.WriteLine(Pricetotal);
        }
        public void Delete()
        {

            Price = 0;
            Name = null;


        }
    }
}
