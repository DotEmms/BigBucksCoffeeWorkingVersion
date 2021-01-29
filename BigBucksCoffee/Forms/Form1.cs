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
    public partial class Form1 : Form
    {
        private IBeverageRepo _repo;
        private IShoppingCart _cart;
        public Form1()
        {
            InitializeComponent();
            _repo = new BeverageRepo();
            _cart = ShoppingCart.GetShoppingCart();

            //Dynamic event handler
            //foreach (var control in this.Controls)
            //{
            //    MyUserControl myUserControl = control as MyUserControl;
            //    if (myUserControl != null)
            //    {
            //        myUserControl.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
            //    }
            //}
            //Event handling => Hook up the delegate in the user control class to a listener in this class
            //myUserControl1.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
            //myUserControl2.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
            //myUserControl3.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
        }

        private void btnDynamic_Click_1(object sender, EventArgs e)
        {
            DynamicControls controls = new DynamicControls();
            controls.Show();
        }
        //Event Handler
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
    }
}
