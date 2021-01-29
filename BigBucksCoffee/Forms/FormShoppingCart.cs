using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls;

namespace BigBucksCoffee
{
    public partial class FormShoppingCart : Form
    {
        BeverageRepo _repo;
        PriceCalculator priceCalculator;
        ShoppingCart _cart;
        public FormShoppingCart()
        {
            InitializeComponent();
            _repo = new BeverageRepo();
            priceCalculator = new PriceCalculator();
            _cart = ShoppingCart.GetShoppingCart();

            //foreach (var control in this.Controls)
            //{
            //    MyUserControl myUserControl = control as MyUserControl;
            //    if (myUserControl != null)
            //    {
            //        myUserControl.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
            //    }
            //}
            var drinks = _repo.GetBeverages();
            ShowShoppingCartItems(drinks);
            
            ShowTotalExclBTW(drinks);
            ShowBTW(drinks);
            ShowTotalInclBTW(drinks);
        }
        public void ShowShoppingCartItems(IEnumerable<IBeverage> drinks)
        {
            foreach (var drink in drinks)
            {
                lblTest.Text += $"{drink.Name} €{drink.Price} {Environment.NewLine}";
            }
        }
        private void AddToCartButtonClickedInUserControl(object sender, EventArgs e)
        {
            // Cast object class to MyUserControl
            MyUserControl myControl = sender as MyUserControl;
            int productId = myControl.DrinkID;
            AddItemToCart(productId);
        }
        private void AddItemToCart(int productId)
        {
            var drink = _repo.GetDrink(productId);
            _cart.AddDrinkToCart(drink);
        }
        public void ShowTotalExclBTW(IEnumerable<IBeverage> beverages)
        {

            lblTotalNoBtw.Text = priceCalculator.CalculateTotalWithoutTax(beverages).ToString();
        }

        public void ShowBTW(IEnumerable<IBeverage> beverages)
        {
            lblTaxAmount.Text = priceCalculator.CalculateTax(beverages).ToString();
        }

        public void ShowTotalInclBTW(IEnumerable<IBeverage> beverages)
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            lblTotal.Text = shoppingCart.CalculatePrice(beverages).ToString();

        }
    }
}
