using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Snackbar
{
    public partial class Form1 : Form
    {
        private SnackBar snackBar;

        public Form1()
        {
            InitializeComponent();
            snackBar = new SnackBar();
            snackBar.AddSnack(new Snack("Chips", 1.50, 10));
            snackBar.AddSnack(new Snack("Chocolate", 2.00, 5));
            snackBar.AddSnack(new Snack("Soda", 1.00, 20));
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int[] amounts = new int[snackBar.GetSnacks().Count];
            amounts[0] = (int)numericUpDown1.Value;
            amounts[1] = (int)numericUpDown2.Value;
            amounts[2] = (int)numericUpDown3.Value;

            double total = snackBar.ProcessOrder(amounts, out List<string> outOfStockSnacks);

            if (total >= 0)
            {
                lblResult.Text = $"Total amount to pay: ${total:F2}";
            }
            else
            {
                lblResult.Text = "Order not possible.\nNot enough stock for: " + string.Join(", ", outOfStockSnacks);
            }
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            double revenue = snackBar.GetRevenue();
            MessageBox.Show($"Current revenue: ${revenue:F2}", "Revenue");
        }

        private void btnUpdateSnack_Click(object sender, EventArgs e)
        {
            int selectedSnackIndex = GetSelectedSnackIndex();
            if (selectedSnackIndex >= 0)
            {
                double newPrice = (double)numericUpDownPrice.Value;
                int newStock = (int)numericUpDownStock.Value;
                Snack selectedSnack = snackBar.GetSnacks()[selectedSnackIndex];
                selectedSnack.UpdatePrice(newPrice);
                selectedSnack.UpdateStock(newStock);
                MessageBox.Show($"Updated {selectedSnack.GetName()} with new price ${newPrice:F2} and stock {newStock}", "Update Snack");
            }
        }

        private int GetSelectedSnackIndex()
        {
            if (radioButton1.Checked) return 0;
            if (radioButton2.Checked) return 1;
            if (radioButton3.Checked) return 2;
            return -1;
        }
    }
}
