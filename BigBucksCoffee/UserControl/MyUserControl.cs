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

        private int _count;

        public int Count
        {
            get { return _count; }
            set
            {
                if (Count > 5)
                {
                    for (int i = 0; i < value; i++)
                    {
                        var drink = _repo.GetDrink(DrinkID);
                        _cart.AddDrinkToCart(drink);
                    }

                    _count += value;
                }
                else
                {
                    MessageBox.Show("Maximum Limit of items!");
                    btnAddToCart.Enabled = false;
                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //var drink = _repo.GetDrink(DrinkID);
            //_cart.AddDrinkToCart(drink);
            //if (Count<5)
            //{
            Count = Convert.ToInt32(Amount);
            //}
            //else
            //{
            //    MessageBox.Show("Maximum Limit of items!");
            //    btnAddToCart.Enabled = false;
            //}

            //if (Count < 5)
            //{
                //for (int i = 0; i < Amount; i++)
                //{
                //    var drink = _repo.GetDrink(DrinkID);
                //    _cart.AddDrinkToCart(drink);
                //}
            //}
            lblTotal.Text = (Count).ToString();
        }

        private void pbProduct_MouseHover(object sender, EventArgs e)
        {
            lblDescription.Visible = true;
            lblDescription.Text = Description;
        }

        private void lblDescription_MouseLeave(object sender, EventArgs e)
        {
            lblDescription.Visible = false;
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            btnAddToCart.Enabled = true;
        }


        private void NumericAddToCart()
        {
            if (Count <5)
            {
                for (int i = 0; i < Amount; i++)
                {
                    var drink = _repo.GetDrink(DrinkID);
                    _cart.AddDrinkToCart(drink);
                }
            }
        }
    }

}
