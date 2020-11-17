using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianPonavljanje4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Price of item: ");
            string itemPrice = Console.ReadLine();
            Console.Write("Enter tax rate (in percentage): ");
            string taxRate = Console.ReadLine();


            TaxCalculator myTaxCalculator = new TaxCalculator(itemPrice, taxRate);
            myTaxCalculator.CalculateTotalPrice();
            myTaxCalculator.GetTotalMsg();
            
            Console.ReadKey();
        }
    }
}
