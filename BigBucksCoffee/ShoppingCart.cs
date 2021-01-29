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
        public List<IBeverage> _beverages;
        private static ShoppingCart _cart;

        public ShoppingCart()
        {
            _beverages = new List<IBeverage>();
        }

        public void AddDrinkToCart(IBeverage beverage)
        {
            _beverages.Add(beverage);
        }

        public static ShoppingCart GetShoppingCart()
        {
            if (_cart == null)
            {
                _cart = new ShoppingCart();
            }

            return _cart;
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
