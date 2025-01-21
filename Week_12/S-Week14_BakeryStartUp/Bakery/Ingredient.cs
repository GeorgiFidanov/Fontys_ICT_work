using System;

namespace Bakery
{
    public class Ingredient
    {
        private string name;
        private decimal price;

        public Ingredient(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public string GetName()
        {
            return name;
        }

        public decimal GetPrice()
        {
            return price;
        }
    }
}