using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Pizza
    {
        public string PizzaName{ get; set; }
        public string PizzaDescription { get; set; }
        public int PizzaCost { get; set; }

        public Pizza()
        {

        }
        public Pizza(string name, string description, int cost)
        {
            this.PizzaName = name;
            this.PizzaDescription = description;
            this.PizzaCost = cost;
        }
    }
}
