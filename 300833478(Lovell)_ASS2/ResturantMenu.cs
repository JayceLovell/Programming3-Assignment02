using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300833478_Lovell__ASS2
{
    class ResturantMenu
    {
        private string _name;
        private string _category;
        private double _price;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }
        public double Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }

        public ResturantMenu(string Name, string Category,double Price)
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
        }
    }
}
