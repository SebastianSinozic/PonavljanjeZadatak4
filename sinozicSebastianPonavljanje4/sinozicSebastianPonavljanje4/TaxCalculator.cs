using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianPonavljanje4
{
    public class TaxCalculator
    {
        private static decimal _itemPrice;
        private static decimal _percentTaxRate;
        private static decimal _totalPrice;

        public TaxCalculator(string inputItemPrice, string inputTaxRate)
        {
            _itemPrice = Decimal.Parse(inputItemPrice);
            _percentTaxRate = Decimal.Parse(inputTaxRate) / 100;
        }

        public void CalculateTotalPrice()
        {
            _totalPrice = _itemPrice + (_itemPrice * _percentTaxRate);
        }

        public void GetTotalMsg()
        {
            Console.WriteLine("The subtotal is {0:C} and the total price is {1:C} at the tax rate of {2:p0}", _itemPrice, _totalPrice, _percentTaxRate);
        }
    }
}
