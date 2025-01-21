using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;


namespace Bakery
{
    public class Sandwich
    {
        private string name;
        private decimal basePrice;
        private BreadType bread;
        private List<Ingredient> ingredients;

        public enum BreadType
        {
            CIABATTA,
            FOCACCIA,
            SOUR_DOUGH,
            RYE,
            WHOLE_WHEAT
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }

        public BreadType Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public Sandwich()
        {
            ingredients = new List<Ingredient>();
        }

        public Sandwich(string name, decimal basePrice, BreadType bread)
        {
            this.name = name;
            this.basePrice = basePrice;
            this.bread = bread;
            this.ingredients = new List<Ingredient>();
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetPrice()
        {
            decimal totalPrice = basePrice;

            foreach (var ingredient in ingredients)
            {
                totalPrice += ingredient.GetPrice();
            }
            return totalPrice;
        }

        public BreadType GetBread()
        {
            return bread;
        }

        public string GetInfo()
        {
            string info = $"{name} {Bread} (";

            for (int i = 0; i < ingredients.Count; i++)
            {
                info += ingredients[i].GetName();
                if (i < ingredients.Count - 1)
                {
                    info += ", ";
                }
            }

            info += ")";
            return info;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            if (ingredient == null)
            {
                throw new ArgumentNullException(nameof(ingredient));
            }

            if (ingredients.Contains(ingredient))
            {
                throw new InvalidOperationException("Ingredient already added");
            }

            if (string.IsNullOrEmpty(ingredient.GetName()))
            {
                throw new ArgumentException("Name must be set");
            }

            if (ingredient.GetPrice() <= 0)
            {
                throw new ArgumentException("Price must be greater than zero");
            }

            if (ingredients.Count >= 5)
            {
                throw new InvalidOperationException("Maximum number of ingredients reached");
            }

            ingredients.Add(ingredient);
        }
    }
}