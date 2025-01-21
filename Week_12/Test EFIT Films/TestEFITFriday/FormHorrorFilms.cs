using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEFITFriday
{
    public partial class FormHorrorFilms : Form
    {
        public FormHorrorFilms()
        {
            InitializeComponent();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anabelle");
        }

        private void buttonMiddle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gilmore Girls");
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Black Mirror");
        }
    }
}
