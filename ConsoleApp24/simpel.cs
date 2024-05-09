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
