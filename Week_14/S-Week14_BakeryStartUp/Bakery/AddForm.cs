using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bakery.Sandwich;

namespace Bakery
{
    public partial class AddForm : Form
    {
        private Bakery bakery;
        private Sandwich sandwich;

        public AddForm(Bakery bakery)
        {
            InitializeComponent();
            this.bakery = bakery;
            sandwich = new Sandwich("", 0, BreadType.CIABATTA); // Initialize with default values
            addIngredients(bakery);
            addBreadTypes(bakery);
        }

        private void addIngredients(Bakery bakeryToAddTo)
        {
            checkedListBox1.Items.Clear();
            foreach (Ingredient ingredient in bakeryToAddTo.GetAvailableIngredients())
            {
                checkedListBox1.Items.Add(ingredient.GetName());
            }
        }

        private void addBreadTypes(Bakery bakeryToAddTo)
        {
            foreach (BreadType breadType in Enum.GetValues(typeof(BreadType)))
            {
                cbbBreadFilter.Items.Add(breadType);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sandwichName = tbxName.Text;
            decimal basePrice = 5.0m; // No information about the basePrice in the assignment

            if (tbxName.Text == "")
            {
                MessageBox.Show("Please enter a name for the sandwich.");
                return;
            }

            if (cbbBreadFilter.SelectedItem == null)
            {
                MessageBox.Show("Please select a bread type.");
                return;
            }

            BreadType breadType;
            if (Enum.TryParse(cbbBreadFilter.SelectedItem.ToString(), out breadType))
            {
                cbbBreadFilter.DataSource = Enum.GetValues(typeof(BreadType));
                sandwich = new Sandwich(sandwichName, basePrice, breadType);

                if (checkedListBox1.CheckedItems.Count > 5)
                {
                    MessageBox.Show("You can only select up to 5 ingredients");
                }
                else
                {
                    foreach (string ingredientName in checkedListBox1.CheckedItems)
                    {
                        foreach (Ingredient ingredient in bakery.GetAvailableIngredients())
                        {
                            if (ingredient.GetName() == ingredientName)
                            {
                                sandwich.AddIngredient(ingredient);
                            }
                        }
                    }
                    this.bakery.AddSandwich(sandwich);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid bread type selected.");
            }
        }
    }
}
