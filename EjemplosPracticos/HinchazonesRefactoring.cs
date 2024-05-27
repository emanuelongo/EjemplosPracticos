using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// EXTRACT METHOD
namespace EjemplosPracticos
{
    internal class HinchazonesRefactoring
    {
        private string name;
        private List<double> transactions;

        public HinchazonesRefactoring(string name, List<double> transactions)
        {
            this.name = name;
            this.transactions = transactions;
        }

        void PrintOwing()
        {
            this.PrintBanner();
            this.PrintDetails(this.GetOutstanding());
        }

        void PrintBanner()
        {
            // Print the banner.
            Console.WriteLine("");
            Console.WriteLine("***** Customer Owes ******");
            Console.WriteLine("");
        }

        double GetOutstanding()
        {
            double outstanding = 0.0;

            // Calculate outstanding.
            foreach (var transaction in transactions)
            {
                outstanding += transaction;
            }

            return outstanding;
        }

        void PrintDetails(double outstanding)
        {
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("amount: " + outstanding);
        }
    }
}
