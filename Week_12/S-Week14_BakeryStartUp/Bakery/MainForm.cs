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
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bakery
{
    public partial class MainForm : Form
    {
        public Bakery bakery;

        public MainForm()
        {
            InitializeComponent();
            bakery = new Bakery("My Bakery");
            cbbBreadFilter.Items.AddRange(Enum.GetValues(typeof(BreadType)).Cast<object>().ToArray());
            lstSandwiches.DataSource = bakery.GetAvailableSandwiches();
            lstSandwiches.DisplayMember = "Name";
        }

        private void btnAddSandwich_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(bakery);
            addForm.ShowDialog();
        }

        private void displayAll(Sandwich[] sandwiches)
        {
            lbxMenu.Items.Clear();
            foreach (Sandwich sandwich in sandwiches)
            {
                lbxMenu.Items.Add(sandwich.GetInfo());
            }
        }

        private void btnShowOfferedSandwiches_Click(object sender, EventArgs e)
        {
            if (cbbBreadFilter.SelectedItem == null)
            {
                displayAll(bakery.GetAvailableSandwiches());
                MessageBox.Show("No bread type selected. Displaying all sandwiches.");
            }
            else
            {
                BreadType selectedBreadType;
                Enum.TryParse(cbbBreadFilter.SelectedItem.ToString(), out selectedBreadType);
                Sandwich[] sandwiches = bakery.GetAvailableSandwiches(selectedBreadType);
                displayAll(sandwiches);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = JsonSerializer.Serialize(this.bakery, new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        Converters = { new JsonStringEnumConverter() }
                    });

                    using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                    using (StreamWriter fileWriter = new StreamWriter(fileStream))
                    {
                        fileWriter.WriteLine(jsonString);
                    }

                    MessageBox.Show($"{bakery.Name} data saved successfully.");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error saving {bakery.Name} data! " + ex.Message);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                RestoreDirectory = true
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        using (StreamReader fileReader = new StreamReader(fileStream))
                        {
                            string jsonString = fileReader.ReadToEnd();
                            bakery = JsonSerializer.Deserialize<Bakery>(jsonString, new JsonSerializerOptions
                            {
                                Converters = { new JsonStringEnumConverter() }
                            });
                        }
                        displayAll(bakery.GetAvailableSandwiches());
                        MessageBox.Show($"{bakery.Name} data successfully loaded!");
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error handling file\n" + ex.Message);
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show($"Error deserializing data:\n" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error!\n" + ex.Message);
                    }
                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Sandwich selectedSandwich = (Sandwich)lstSandwiches.SelectedItem;
            if (selectedSandwich != null)
            {
                decimal priceWithVAT = bakery.SellSandwich(selectedSandwich);
                MessageBox.Show($"Sandwich sold for {priceWithVAT:F2}");
            }
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            bool includeVAT = chkIncludeVAT.Checked;
            decimal revenue = bakery.CalculateRevenue(includeVAT);
            MessageBox.Show($"Total revenue: {revenue:F2}");
        }

        private void lbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxMenu.SelectedItem != null)
            {
                string selectedSandwichInfo = lbxMenu.SelectedItem.ToString();


                var availableSandwiches = bakery.GetAvailableSandwiches();

                Sandwich selectedSandwich = availableSandwiches.FirstOrDefault(s => s.GetInfo() == selectedSandwichInfo);

                if (selectedSandwich != null)
                {
                    bakery.AddSandwich(selectedSandwich);
                    lstSandwiches.DataSource = bakery.GetAvailableSandwiches();
                    lstSandwiches.DisplayMember = "Name";
                }
            }
        }
    }
}
