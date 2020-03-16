using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Program
    {
        static void Main(string[] args)
        {


            Automaton logic = new Automaton();

            logic.CreateBounty();
            logic.CreateKinderBueno();
            logic.CreateMarsBar();
            logic.CreateMilkyWay();
            logic.CreateTwix();


            Console.WriteLine("Please insert Euro coins into the macine (Type 0 if you want to administrate the automaton)");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (true)

            {

                Console.Clear();

                if (userInput > 0)


                {
                    Console.WriteLine("You have " + (userInput - i) + " Euros to buy chocolate bars for ");
                    i++;


                }  

                else if (userInput == 0)
                    
                {
                 
                    Console.Clear();
                    Console.WriteLine("Login");
                    string login = Console.ReadLine();
                    if (login == "Admin")

                    {
                        Console.Clear();
                        Console.WriteLine("Password");
                        string password = Console.ReadLine();

                        if (password == "auto")
                        {

                        }

                            else
                        {
                            Console.WriteLine("The password you have entered is incorrect");
                            Console.ReadKey();
                        }

                        try
                            {
                                Console.Clear();
                                Console.WriteLine("(1) Add Item");
                                Console.WriteLine("(2) Remove Item");
                                Console.WriteLine("(3) Change Price");
                                Console.WriteLine("(4) Log Off");
                                Console.WriteLine("(5) Turn Off");
                                Console.WriteLine();
                                Console.ReadKey();
                                int managementInput = Convert.ToInt32(Console.ReadLine());


                                if (managementInput == 1)

                                {
                                    Console.Write("What item would you like to add");
                                    Console.WriteLine("(1) Mars Bar");
                                    Console.WriteLine("(2) Twix");
                                    Console.WriteLine("(3) Bounty");
                                    Console.WriteLine("(4) Kinder Bueno");
                                    Console.WriteLine("(5) Milky Way");

                                    int itemAddInput = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("How many bars would you like to add?");
                                    int itemAmountInput = Convert.ToInt32(Console.ReadLine());
                                    Automaton logik = new Automaton();

                                    if (itemAddInput == 1)
                                    {
                                        for (int b = 0; b <= itemAmountInput; b++)
                                        {

                                        }
                                    }
                                }


                                else if (managementInput == 2)
                                {
                                    Console.WriteLine("What item would you like to remove?");
                                    Console.WriteLine("(1) Mars Bar");
                                    Console.WriteLine("(2) Twix");
                                    Console.WriteLine("(3) Bounty");
                                    Console.WriteLine("(4) Kinder Bueno");
                                    Console.WriteLine("(5) Milky Way");

                                    int itemRemoveInput = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("How many bars would you like to remove?");


                                    //remove item
                                }

                                else if (managementInput == 3)
                                {
                                    //adjust price
                                }

                                else if (managementInput == 4)
                                {
                                    //log off
                                }

                                else if (managementInput == 5)
                                {
                                    Environment.Exit(1);
                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("You can only use the number 1-5");
                            }
                    }

                else

                {
                    Console.WriteLine("You need to put coins into the machine");
                }

                {
                foreach (var bar in logic.GetMarsBar())
                    {
                     Console.Write("[" + bar.Name + "]");
                    }

                     Console.WriteLine("\n");
                     foreach (var bar in logic.GetBonuty())
                     {
                      Console.Write("[" + bar.Name + "]");
                     }

                      Console.WriteLine("\n");
                      foreach (var bar in logic.GetKinderBueno())
                      {
                       Console.Write("[" + bar.Name + "]");
                      }

                       Console.WriteLine("\n");
                       foreach (var bar in logic.GetMilkyWay())
                      {
                       Console.Write("[" + bar.Name + "]");
                      }

                       Console.WriteLine("\n");
                       foreach (var bar in logic.GetTwix())
                      {
                       Console.Write("[" + bar.Name + "]");
                      }

                       Console.WriteLine("\nWrite the chocolate bar you want to buy");
                       string userInput1 = Console.ReadLine();
                       logic.purchase(userInput1);
                }

                }
            }
        }
    }
}
