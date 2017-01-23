using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300833478_Lovell__ASS2
{
    public partial class BillCalculator : Form
    {
        static List<ResturantMenu> MenuItems = new List<ResturantMenu>();
        double Subtotal;
        public BillCalculator()
        {
            InitializeComponent();
        }

        private void BillCalculator_Load(object sender, EventArgs e)
        {
            _createMenu();
            _addtoboxes();
        }
        /// <summary>
        /// adding info fromlist to combo boxes
        /// </summary>
        private void _addtoboxes()
        {
            foreach(var item in MenuItems)
            {
                switch (item.Category)
                {
                    case "Beverage":
                        BeverageCmbox.Items.Add(item.Name);
                        break;
                    case "Appetizer":
                        AppetizerCmbB.Items.Add(item.Name);
                        break;
                    case "Dessert":
                        DessertCmbB.Items.Add(item.Name);
                        break;
                    case "Main Course":
                        MainCourseCmbB.Items.Add(item.Name);
                        break;
                    default:
                        break;
                }       
            }
        }

        /// <summary>
        /// creating list instead of database style :)
        /// </summary>
        private void _createMenu()
        {
            //Adding Beverage to list
            MenuItems.Add(new ResturantMenu("Soda","Beverage",1.95));
            MenuItems.Add(new ResturantMenu("Tea", "Beverage", 1.50));
            MenuItems.Add(new ResturantMenu("Coffee", "Beverage", 1.25));
            MenuItems.Add(new ResturantMenu("Mineral Water","Beverage",2.95));
            MenuItems.Add(new ResturantMenu("Juice", "Beverage",2.50));
            MenuItems.Add(new ResturantMenu("Milk", "Beverage",1.50));
            //Adding Appetizers to list
            MenuItems.Add(new ResturantMenu("Buffalo Wings", "Appetizer",5.95));
            MenuItems.Add(new ResturantMenu("Buffalo Fingers", "Appetizer",6.95));
            MenuItems.Add(new ResturantMenu("Potato Skins", "Appetizer",8.95));
            MenuItems.Add(new ResturantMenu("Nachos", "Appetizer",8.95));
            MenuItems.Add(new ResturantMenu("Mushroom Caps", "Appetizer",10.95));
            MenuItems.Add(new ResturantMenu("Shrimp Cocktail", "Appetizer",12.95));
            MenuItems.Add(new ResturantMenu("Chips and Salse", "Appetizer",6.95));
            //Adding Main Course to list
            MenuItems.Add(new ResturantMenu("Seafood Alfredo", "Main Course",15.95));
            MenuItems.Add(new ResturantMenu("Chicken Alfredo", "Main Course",13.95));
            MenuItems.Add(new ResturantMenu("Chicken Picatta", "Main Course",13.95));
            MenuItems.Add(new ResturantMenu("Turkey Club", "Main Course",11.95));
            MenuItems.Add(new ResturantMenu("Lobster Pie", "Main Course",11.95));
            MenuItems.Add(new ResturantMenu("Prime Rib", "Main Course",20.95));
            MenuItems.Add(new ResturantMenu("Shrimp Scampi", "Main Course",18.95));
            MenuItems.Add(new ResturantMenu("Turkey Dinner", "Main Course",13.95));
            MenuItems.Add(new ResturantMenu("Stuffed Chicken", "Main Course",14.95));
            //Adding Dessert to list
            MenuItems.Add(new ResturantMenu("Apple Pie", "Dessert",5.95));
            MenuItems.Add(new ResturantMenu("Sundae", "Dessert",3.95));
            MenuItems.Add(new ResturantMenu("Carrot Cake", "Dessert",5.95));
            MenuItems.Add(new ResturantMenu("Mud Pie", "Dessert",4.95));
            MenuItems.Add(new ResturantMenu("Apple Crisp", "Dessert",5.95));
        }
        /// <summary>
        /// Opens link in browsers
        /// </summary>
        private void companylogolbl_Click(object sender, EventArgs e)
        {
            Process.Start("https://fantasyburgers.azurewebsites.net/");
        }
        /// <summary>
        /// Clear fields
        /// </summary>
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = "$0.00";
            txtTax.Text = "$0.00";
            txtTotal.Text = "$0.00";
            Subtotal = 0;
        }
        /// <summary>
        /// Gets selected and does calculations
        /// </summary>
        private void ItemSelected(object sender, EventArgs e)
        {
            ComboBox cmd = (ComboBox)sender;

            var Selected=MenuItems.Find(x => x.Name.Contains(cmd.SelectedItem.ToString()));
            double _price=Selected.Price;
            Subtotal += _price;
            txtSubtotal.Text = Subtotal.ToString("C", CultureInfo.CurrentCulture);
            double _tax = (Subtotal*13)/100;
            txtTax.Text = _tax.ToString("C", CultureInfo.CurrentCulture);
            double _total = Subtotal + _tax;
            txtTotal.Text = _total.ToString("C", CultureInfo.CurrentCulture);
        }
        private void Calculate(object sender, EventArgs e)
        {
          
        }
    }
}
