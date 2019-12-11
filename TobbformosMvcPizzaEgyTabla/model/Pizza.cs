using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasEgyTabla.Model
{
    partial class Pizza
    {
        private int id;
        private string name;
        private int price;
        
        public Pizza(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;           
        }
        public void setID(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
        public int getId()
        {
            return id;
        }
        public string getNeme()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
    }
}
