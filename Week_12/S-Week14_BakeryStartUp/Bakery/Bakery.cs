using System;
using System.Collections.Generic;
using System.Diagnostics;
using static Bakery.Sandwich;


namespace Bakery
{
    public class Bakery
    {
        private int VAT_PERSENTAGE = 9;
        private string name;
        private List<Sandwich> sandwichesOffered;
        private List<Ingredient> ingredientsAvailable;
        private List<Sandwich> soldSandwiches; // New instance variable

        public int VAT_PERSENTAGE1 { get => VAT_PERSENTAGE; set => VAT_PERSENTAGE = value; }
        public string Name { get => name; set => name = value; }
        public List<Sandwich> SandwichesOffered { get => sandwichesOffered; set => sandwichesOffered = value; }
        public List<Ingredient> IngredientsAvailable { get => ingredientsAvailable; set => ingredientsAvailable = value; }

        public Bakery(string name)
        {
            this.name = name;
            sandwichesOffered = new List<Sandwich>();
            ingredientsAvailable = new List<Ingredient>();
            soldSandwiches = new List<Sandwich>(); // Initialize the list
            AddIngredients();
        }

        private void AddIngredients()
        {
            ingredientsAvailable.Add(new Ingredient("Cucumber", 0.05m));
            ingredientsAvailable.Add(new Ingredient("Tomato", 0.15m));
            ingredientsAvailable.Add(new Ingredient("Cheddar", 0.2m));
            ingredientsAvailable.Add(new Ingredient("Ham", 0.15m));
            ingredientsAvailable.Add(new Ingredient("Chorizo", 0.25m));
            ingredientsAvailable.Add(new Ingredient("Apple", 0.1m));
            ingredientsAvailable.Add(new Ingredient("Tuna", 0.2m));
            ingredientsAvailable.Add(new Ingredient("Smoked Salmon", 0.4m));
            ingredientsAvailable.Add(new Ingredient("Cream cheese", 0.15m));
            ingredientsAvailable.Add(new Ingredient("Gouda cheese", 0.1m));
        }

        public string GetName()
        {
            return name;
        }

        public Ingredient[] GetAvailableIngredients()
        {
            return ingredientsAvailable.ToArray();
        }

        public void AddSandwich(Sandwich sandwich)
        {
            if (sandwich != null)
            {
                sandwichesOffered.Add(sandwich);
            }
        }

        public Sandwich[] GetAvailableSandwiches()
        {
            return sandwichesOffered.ToArray();
        }

        public Sandwich[] GetAvailableSandwiches(BreadType bread)
        {
            List<Sandwich> filteredSandwiches = new List<Sandwich>();
            foreach (Sandwich sandwich in sandwichesOffered)
            {
                if (sandwich.GetBread() == bread)
                {
                    filteredSandwiches.Add(sandwich);
                }
            }
            return filteredSandwiches.ToArray();
        }

        public decimal SellSandwich(Sandwich sandwich)
        {
            soldSandwiches.Add(sandwich);
            decimal priceWithVAT = sandwich.GetPrice() * (1 + VAT_PERSENTAGE / 100.0m);
            return priceWithVAT;
        }

        public decimal CalculateRevenue(bool includeVAT)
        {
            decimal totalRevenue = 0;
            foreach (Sandwich sandwich in soldSandwiches)
            {
                decimal price = sandwich.GetPrice();
                if (includeVAT)
                {
                    price *= (1 + VAT_PERSENTAGE / 100.0m);
                }
                totalRevenue += price;
            }
            return totalRevenue;
        }
    }
}
