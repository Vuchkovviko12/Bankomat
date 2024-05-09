Program.cs
//////////////////////////
using System.Runtime.InteropServices;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simpel = new simpel();
            double Balance = 300;

            Console.WriteLine("CardNumbers");
            simpel.CardNumbers(); 
            Console.WriteLine("CardHolders");
            simpel.CardHolders = Console.ReadLine();
            Console.WriteLine("Dates");
            simpel.Dates();
            
            simpel.SomeSHIT();
            while (true)
            {


                string a1 = Console.ReadLine();
                if (a1 == "Balance")
                {
                    Console.WriteLine($"Balance is {Balance}");
                }
                else if (a1 == "withdrawal")
                {
                    double withdrawal = double.Parse(Console.ReadLine());
                    Balance -=withdrawal;
                    if (withdrawal > 300)
                    {
                        Console.WriteLine("You Dont have enough money ");
                    }
                    if (withdrawal < 300)
                    {
                        Console.WriteLine("Trasaction pending");
                    }

                }
                else if (a1 == "Deposit")
                {
                    double Deposite = double.Parse(Console.ReadLine());
                    Balance +=Deposite;
                    Console.WriteLine("Trasaction pending");

                }
                

            }


        }
    }
}



simple.cs
////////////////////////////////////////////////////////////////////////////



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class simpel
    {
        private int CardNumber;
        private string CardHolder;
        private int Date;


        public void CardNumbers()
        {
            List<int>CardNumberss = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
         }
    
        public void Dates()
        {
            List<int>Date = Console.ReadLine().Split('/').Select(int.Parse).ToList();

    }
        public string CardHolders
        {
            get { return CardHolder; }
            set { CardHolder = value; }

        }
        public void SomeSHIT()
        {
            Console.WriteLine("Balance");
            Console.WriteLine("withdrawal");
            Console.WriteLine("Deposit");
        }
        
    }
}
