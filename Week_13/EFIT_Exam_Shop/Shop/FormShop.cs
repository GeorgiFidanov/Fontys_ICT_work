using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Shop
{
    public partial class FormShop : Form
    {
        public ProdcutsCollection collection;

        public FormShop()
        {
            InitializeComponent();
            this.collection = new ProdcutsCollection();
            AddTestData();
        }

        private void AddTestData()
        {
            collection.AddProduct("Soap", 3.49m);
            collection.AddProduct("Toothpaste", 1.29m);
            collection.AddProduct("Shampoo", 2.39m);
            collection.AddProduct("Detergent", 7.49m);
            collection.AddProduct("Bag", 0.60m);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);


            if (!String.IsNullOrEmpty(name) && price > 0)
            {
                collection.AddProduct(name, price);
                listBoxInformation.Items.Add(collection.GetOneProduct(name).GetInfo());
                textBoxName.Clear();
                textBoxPrice.Clear();

            }

            else
            {
                MessageBox.Show("Please supply a valid name and/or price");
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBoxInformation.Items.Clear();
            foreach (Product product in collection.GetAllProducts())
            {
                listBoxInformation.Items.Add(product.GetInfo());
            }
        }

        private void buttonShowOne_Click(object sender, EventArgs e)
        {
            string productName = textBoxNameForSearch.Text;
            listBoxInformation.Items.Clear();
            listBoxInformation.Items.Add(collection.GetOneProduct(productName).GetInfo());

            if (checkBoxFuture.Checked)
            {
                int inflationRate = Convert.ToInt32(textBoxInflation.Text);
                decimal limit = Convert.ToDecimal(textBoxLimit.Text);

                if ( 1 < inflationRate && inflationRate < 100 && limit > 0)
                {
                    List<decimal> inflation = collection.GetOneProduct(productName).GetFututeAnalysis(inflationRate, limit);
                    int years = inflation.Count;
                    listBoxInformation.Items.Add($"It takes {inflation.Count} years");
                    int yearsCounter = 0;
                    foreach(decimal newPrice in inflation)
                    {
                        yearsCounter++;
                        listBoxInformation.Items.Add($"In year - {yearsCounter} the price will be{newPrice}");
                    }
                }
                else
                {
                    MessageBox.Show("Please supply a valid name and/or price");
                }


            }
        }
    }
}
