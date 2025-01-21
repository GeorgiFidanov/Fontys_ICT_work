using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfNumbers
{
    public partial class NumbersForm : Form
    {
        public NumbersForm()
        {
            InitializeComponent();
        }

        private void buttonForListing_Click(object sender, EventArgs e)
        {
            int INITIAL_NUMBER = 1;  // In capital letters (upper case) because they are constants
            int FINAL_NUMBER = 20;

            listBoxNumbers.Items.Clear();

            switch (comboBoxMenu.Text)
            {
                case "Ascending":
                    ShowAscending(INITIAL_NUMBER, FINAL_NUMBER);
                    break;

                case "Descending":
                    ShowDescending(FINAL_NUMBER, INITIAL_NUMBER);
                    break;

                case "Post delivery from below":
                    ShowPostFromBelow(INITIAL_NUMBER, FINAL_NUMBER);
                    break;

                case "Post delivery from above":
                    ShowPostFromAbove(FINAL_NUMBER, INITIAL_NUMBER);
                    break;

                default:
                    MessageBox.Show("Your choice from the menu \"" + comboBoxMenu.Text + "\" is not valid");
                    break;
            }
        }

        private void ShowAscending(int start, int end)
        {
            for (int currentNumber = start; currentNumber <= end; currentNumber++)
            {
                listBoxNumbers.Items.Add(currentNumber);
            }
        }

        private void ShowDescending(int start, int end)
        {
            for (int currentNumber = start; currentNumber >= end; currentNumber--)
            {
                listBoxNumbers.Items.Add(currentNumber);
            }
        }

        private void ShowPostFromBelow(int start, int end)
        {
            int middle = (start + end) / 2;
            for (int currentNumber = middle; currentNumber <= end; currentNumber++)
            {
                listBoxNumbers.Items.Add(currentNumber);
            }
            for (int currentNumber = start; currentNumber < middle; currentNumber++)
            {
                listBoxNumbers.Items.Add(currentNumber);
            }
        }

        private void ShowPostFromAbove(int start, int end)
        {
            int middle = (start + end) / 2;
            for (int currentNumber = middle; currentNumber >= end; currentNumber--)
            {
                listBoxNumbers.Items.Add(currentNumber);
            }
            for (int currentNumber = start; currentNumber > middle; currentNumber--)
            {
                listBoxNumbers.Items.Add(currentNumber);
            }
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
