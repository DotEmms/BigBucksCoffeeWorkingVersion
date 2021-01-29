using System;
using System.Windows.Forms;

namespace UserControls
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonAddToCartClicked;

        protected virtual void OnButtonAddToCartClicked(EventArgs e)
        {
            ButtonAddToCartClicked?.Invoke(this, e);
        }

        public int MaxCount { get; set; } = 5;

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
                if ((Count + value) <= MaxCount)
                {
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
            Count = Convert.ToInt32(Amount);
            lblTotal.Text = (Count).ToString();
            OnButtonAddToCartClicked(e);
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
    }
}