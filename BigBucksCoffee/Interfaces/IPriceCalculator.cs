using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    interface IPriceCalculator
    {
        double CalculateTax(IEnumerable<IBeverage> beverages);

        double CalculateTotalWithoutTax(IEnumerable<IBeverage> beverages);

    }
}
