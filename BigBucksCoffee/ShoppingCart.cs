using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    public class ShoppingCart : IShoppingCart
    {
        //We have to change it later
        private List<IBeverage> _beverages;
        private static ShoppingCart _shoppingCart;
        private ShoppingCart()
        {
            _beverages = new List<IBeverage>();

        }
        public static ShoppingCart GetCart()
        {
            if (_shoppingCart ==null)
            {
                _shoppingCart = new ShoppingCart();
            }
            return _shoppingCart;
        }

        public void AddDrinkToCart(IBeverage beverage)
        {
            _beverages.Add(beverage);
        }

        public IEnumerable<IBeverage> GetDrinksInCart()
        {
            return _beverages;
        }  
      

        public double CalculatePrice(IEnumerable<IBeverage> beverages)
        {
            double total = 0;
            int i = 0;
            foreach (var item in beverages)
            {
                total += item.Price;
                i++;
            }
            return Math.Round(total, 2);
        }
    }
}
