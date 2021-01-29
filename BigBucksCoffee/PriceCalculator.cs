using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    class PriceCalculator : IPriceCalculator
    {

        public double CalculateTax(IEnumerable<IBeverage> beverages)
        {
            double total = 0;
            int i = 0;
            foreach (var item in beverages)
            {
                total += item.Price;
                i++;
            }
            total = total / 100 * 21;
            return Math.Round(total, 2);
        }

        public double CalculateTotalWithoutTax(IEnumerable<IBeverage> beverages)
        {
            double total = 0;
            int i = 0;
            foreach (var item in beverages)
            {
                total += item.Price;
                i++;
            }
            total = total / 100 * 79;
            return Math.Round(total, 2);
        }

      
    }
}
