using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//METHOD LARGE
namespace EjemplosPracticos
{
    internal class HinchazonesSmell
    {
        private string name;
        private List<double> transactions;

        public HinchazonesSmell(string name, List<double> transactions)
        {
            this.name = name;
            this.transactions = transactions;
        }

        void PrintOwing()
        {
            this.PrintBanner();

            // Print details.
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("amount: " + this.GetOutstanding());
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
    }
}
