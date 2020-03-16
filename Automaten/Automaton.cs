using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Automaton
    {
        static Stack<Chocolate> Mars_Bar = new Stack<Chocolate>();
        static Stack<Chocolate> Twix = new Stack<Chocolate>();
        static Stack<Chocolate> Bounty = new Stack<Chocolate>();
        static Stack<Chocolate> Kinder_Bueno = new Stack<Chocolate>();
        static Stack<Chocolate> Milky_Way = new Stack<Chocolate>();

        Chocolate mars_Bar = new Chocolate("Mars Bar", 1);
        Chocolate twix = new Chocolate("Twix", 1);
        Chocolate bounty = new Chocolate("Bounty", 1);
        Chocolate kinder_bueno = new Chocolate("Kinder Bueno", 1);
        Chocolate milky_way = new Chocolate("Milky Way", 1);



        int userMoney = 0;

        public Stack<Chocolate> GetMarsBar()
        {
            return Mars_Bar;
        }

        public Stack<Chocolate> GetTwix()
        {
            return Twix;
        }

        public Stack<Chocolate> GetBonuty()
        {
            return Bounty;
        }

        public Stack<Chocolate> GetKinderBueno()
        {
            return Kinder_Bueno;
        }

        public Stack<Chocolate> GetMilkyWay()
        {
            return Milky_Way;
        }


        public void CreateMarsBar()
        {

                for (int i = 0; i <= 9; i++)
                {
                Chocolate mars_Bar = new Chocolate("Mars Bar", 1);
                Mars_Bar.Push(mars_Bar);
                    
                }
        }

        public void CreateTwix()
        {
                for (int i = 0; i <= 9; i++)
                {
                Chocolate twix = new Chocolate("Twix", 1);
                Twix.Push(twix);
                }
        }

        public void CreateBounty()
        {

                for (int i = 0; i <= 9; i++)
                {
                Chocolate bounty = new Chocolate("Bounty", 1);
                Bounty.Push(bounty);
                }
            
        }

        public void CreateKinderBueno()
        {

                for (int i = 0; i <= 9; i++)
                {
                Chocolate kinder_bueno = new Chocolate("Kinder Bueno", 1);
                Kinder_Bueno.Push(kinder_bueno);
                }
            
        }

        public void CreateMilkyWay()
        {

                for (int i = 0; i <= 9; i++)
                {
                Chocolate milky_way = new Chocolate("Milky Way", 1);
                Milky_Way.Push(milky_way);
                }
            
        }

        public void purchase(string input)
        {

            if (input == "Mars Bar" || input == "Twix" || input == "Kinder Bueno" || input == "Milky Way" ||
                input == "Bounty")
            {
                Console.Write("\nPlease pay 1 Euro\n");
                Console.Write("Pay: ");
                userMoney = int.Parse(Console.ReadLine());


            }

            else
            {
                Console.WriteLine("\nThe bar you wanted to purchase is no longer available");
                Console.ReadKey();

            }

            if (input == "Mars Bar" && userMoney >= 1)
            {
                Mars_Bar.Pop();
                Console.WriteLine("1 Mars Bar is on the way!");
                Console.ReadKey();


            }

            else if (input == "Milky Way" && userMoney >= 1)
            {
                Milky_Way.Pop();
                Console.WriteLine("1 Milky Way is on the way!");
                Console.ReadKey();
            }

            else if (input == "Twix" && userMoney >= 1)

            {
                Twix.Pop();
                Console.WriteLine("1 Twix is on the way!");
                Console.ReadKey();
            }

            else if (input == "Kinder Bueno" && userMoney >= 1)
            {
                Kinder_Bueno.Pop();
                Console.WriteLine("1 Kinder Bueno is on the way!");
                Console.ReadKey();
            }

            else if (input == "Bounty" && userMoney >= 1)
            {
                Bounty.Pop();
                Console.WriteLine("1 Bounty is on the way!");
                Console.ReadKey();
            }


            

        }
    }
}
