using BigBucksCoffee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace UserControls
{
    public partial class MyUserControl : UserControl
    {
        public ShoppingCart _cart;
        private IBeverageRepo _repo;
        //double tempPrice;

        public MyUserControl()
        {
            InitializeComponent();
            _cart = ShoppingCart.GetShoppingCart();
            _repo = new BeverageRepo();
        }
       

        public int DrinkID { get; set; }

        public string MyProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }

        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public decimal Amount
        {
            get { return numAmount.Value; }
            set { numAmount.Value = value; }
        }

        public bool IsInStock
        {
            get { return cbIsInStock.Checked; }
            set { cbIsInStock.Checked = value; }
        }

        private string _image;

        public string Image
        {
            set
            {
                if (value != null)
                {
                    _image = value;
                    pbProduct.ImageLocation = _image;
                    pbProduct.Load(_image);
                }
            }
        }
        int count = 0;
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            var drink = _repo.GetDrink(DrinkID);
            _cart.AddDrinkToCart(drink);
            // lblTotal.Text =  Convert.ToString(_cart.CalculatePrice(drink));
            count++;

            lblTotal.Text = (count).ToString();
        }

    }
}
