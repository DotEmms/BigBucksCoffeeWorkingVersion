using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    interface IBeverageRepo
    {
        List<IBeverage> GetBeverages();
        IBeverage GetDrink(int id);
    }
}
