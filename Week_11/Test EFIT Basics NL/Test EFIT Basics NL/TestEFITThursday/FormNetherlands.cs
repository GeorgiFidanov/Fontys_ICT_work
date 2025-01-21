using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEFITThursday
{
    public partial class FormNetherlands : Form
    {
        public FormNetherlands()
        {
            InitializeComponent();
        }

        private void buttonCapital_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The capital of the Netherlands is: Amsterdam");
        }

        private void buttonPrimeMinister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Prime Minister of the Netherlands is: Geert Wilders");
        }

        private void buttonEindhoven_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eindhoven is the capital of: nothing – it is not a capital");
        }
    }
}
