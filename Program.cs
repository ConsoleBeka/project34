using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        
        static void Main(string[] args)
        {
            List<User> one = new List<User>();
            List<Product> two = new List<Product>();
            List<Cart> three = new List<Cart>();
            int check = 0;
            int iu = -2;


           

            do
            {
                User user = new User();
                
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1 Register");
                Console.WriteLine("2 Log-In");
                Console.WriteLine("3 Buy");
                Console.WriteLine("4 Cart");
                Console.WriteLine("5 Log-out");
                Console.WriteLine("6 Users(only for admin)");
                Console.WriteLine("7 Add products");

                // string input;
                string input = Console.ReadLine();
                Product product = new Product();

                //product.Input("Milk",23);
                //two.Add(product);

                //product.Input( "Butter",15);
                //two.Add(product);

                //product.Input("Cow",233);
                //two.Add(product);

                //product.Input("Meat",53 );
                //two.Add(product);

                //product.Input("Soy", 43);
                //two.Add(product);

                //product.Input( "Cereal",53);
                //two.Add(product);
                switch (input)
                {
                    case "1":

                        Console.Clear();

                        user.Input();

                        one.Add(user);

                        Console.Clear();



                        break;
                    case "2":
                        string firstN;
                        string lastN;
                        string pass;
                        int checkv = 0;
                        if (check ==0)
                        {
                            Console.WriteLine("Name");
                            firstN = Console.ReadLine();

                            Console.WriteLine("Surname");
                            lastN = Console.ReadLine();

                            Console.WriteLine("Password");
                            pass = Console.ReadLine();


                            foreach (User use in one)
                            {
                                if (firstN == use.FirstName && lastN == use.LastName && pass == use.Password)
                                {
                                    checkv += 3;
                                    iu = use.Id;
                                }

                            }
                            //if (firstN == user.FirstName)
                            //{
                            //    checkv++;
                            //}
                            //if (lastN == user.LastName)
                            //{
                            //    checkv++;
                            //}
                            //if (pass == user.Password)
                            //{
                            //    checkv++;
                            //}
                            if (checkv==3)
                                {
                                Console.Clear();
                                Console.Write("Welcome ");
                                Console.Write(firstN);

                                Console.ReadLine();
                                check++;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong input");
                                Console.ReadLine();
                            }

                        }
                        else {
                            Console.Clear();
                            Console.WriteLine("Already logged-in");
                            Console.ReadLine();
                        }
                        break;
                    case "3":
                        Console.Clear();
                        string chose;
                        foreach(Product pro in two)
                        {

                            pro.View();
                        }
                        Console.WriteLine("Type name of product, to add to cart");
                        chose =Console.ReadLine();
                        if (iu != -2) {
                            foreach (Product prd in two)
                            {
                                if (chose==prd.Name)
                                {
                                    Cart cart = new Cart();
                                    
                                    cart.Price = prd.Price;
                                    cart.Name = prd.Name;
                                    cart.Id = user.Id;
                                    three.Add(cart);    
                                }

                            }
                           
                        }
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        if (iu == -2) { Console.WriteLine("No user found"); }

                        else { Console.WriteLine("Cart"); 
                        foreach (User usr in one)
                        {
                            if (iu == usr.Id)
                            {
                                Console.WriteLine(usr.FirstName);
                            }
                        }
                        foreach (Cart cart in three)
                        {

                            cart.View();
                            
                        }
                        Console.WriteLine("Do you want to proceed? yes/no");
                        
                        string res=Console.ReadLine();
                        if (res == "yes") {
                            foreach (Cart cart in three)
                            {

                                cart.Delete();

                            }
                        }
                        if (res == "no")
                        {
                            Console.ReadLine();
                        }}
                        Console.ReadLine();
                        
                        //Console.Clear();


                        //    foreach (User aPart in one)
                        //    {
                        //        Console.WriteLine(aPart);
                        //    }
                        //    user.View();
                        break;

                    case "5":
                        check--;
                        if (check < 0)
                        {
                            check = 0;
                        }
                        iu = -2;
                        break;
                    case "6":
                        
                        Console.Clear();
                        string key = "admin";
                        string key1;
                        key1=Console.ReadLine();
                        if (key1==key)
                        {
                           
                            foreach (User usr in one)
                            {
                                usr.View();
                            }
                            Console.ReadLine();
                        }
                        else {
                            Console.WriteLine("Wrong key");
                            Console.ReadLine();
                        }
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case "7":

                        Console.Clear();
                   
                        product.Input1();
                        two.Add(product);

                        Console.Clear();


                        Console.ReadLine();
                        break;
                }
            } while (true);
        }
       
    }
}