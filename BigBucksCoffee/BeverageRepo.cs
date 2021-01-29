using System.Collections.Generic;
using System.Linq;

namespace BigBucksCoffee
{
    public class BeverageRepo : IBeverageRepo
    {
        public List<IBeverage> GetBeverages()
        {
            var drinks = new List<IBeverage>
        {
            new Tea(1, "Green Tea","Just green tea", 3, @"Images\greenTea.png", true,true,false,true),
            new Tea(2, "Black Tea","Just black tea", 4, @"Images\blackTea.jpg", true,false,true,true),
            new Coffee(3, "Black Coffee", "Black coffee", 2.5, @"Images\coffee2.jpg", false, true, false),
            new Smoothie(4,"Morning smoothie","Strawberry Banana", 6.99,@"Images\strawberrySmoothie.jpg",true,true,true),
            new Soda(5, "Fanta orange","Fanta orange", 2.5,@"Images\fanta.jpg",false,true,false),
        };

            return drinks;
        }
        public IBeverage GetDrink(int id)
        {
            List<IBeverage> allDrinks = GetBeverages();
            var listOfBeverages = allDrinks.Where(x => x.ID == id).FirstOrDefault();

            return listOfBeverages;
        }

        
    }
}