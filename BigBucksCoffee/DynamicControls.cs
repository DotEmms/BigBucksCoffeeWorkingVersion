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
    public partial class DynamicControls : Form
    {
        BeverageRepo beverageRepo;
        FormShoppingCart _formShoppingCart;
        List<IBeverage> drinks;

        public DynamicControls()
        {
            InitializeComponent();
            beverageRepo = new BeverageRepo();
            drinks = beverageRepo.GetBeverages();
            GenerateControlsForDrinks(drinks);
            _formShoppingCart = new FormShoppingCart();
        }
        private void GenerateControlsForDrinks(IEnumerable<IBeverage> drinks)
        {
            foreach (IBeverage drink in drinks)
            {
                MyUserControl myUserControl = new MyUserControl
                {
                    DrinkID = drink.ID,
                    MyProductName = drink.Name,
                    Price = drink.Price.ToString(),
                    //IsInStock = drink.IsInStock,
                    Description = drink.Description,
                    Image = drink.Image
                };

                flowLayoutPanel1.Controls.Add(myUserControl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formCart = new FormShoppingCart();
            formCart.Show();
            _formShoppingCart.ShowShoppingCartItems(drinks);
        }
    }
}
