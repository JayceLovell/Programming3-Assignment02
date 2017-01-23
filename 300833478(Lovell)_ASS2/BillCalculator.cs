using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300833478_Lovell__ASS2
{
    public partial class BillCalculator : Form
    {
        static List<ResturantMenu> MenuItems = new List<ResturantMenu>();
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
    }
}
