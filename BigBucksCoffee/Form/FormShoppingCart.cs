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
        BeverageRepo beverageRepo;
        PriceCalculator priceCalculator;
        ShoppingCart myCart;
        MyUserControl myUserControl = new MyUserControl();
        public FormShoppingCart()
        {
            InitializeComponent();
            beverageRepo = new BeverageRepo();
            priceCalculator = new PriceCalculator();
            myCart = ShoppingCart.GetCart();
            var drinks = myCart.GetDrinksInCart();
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
            ShoppingCart shoppingCart = ShoppingCart.GetCart();
            lblTotal.Text = shoppingCart.CalculatePrice(beverages).ToString();

        }
    }
}
