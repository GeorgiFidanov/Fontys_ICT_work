using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTasks
{
    public partial class LogInForm : Form
    {
        private Company company;
        private string username;
        private string password;

        public LogInForm(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Retrieve input
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            // Check if employees list is loaded
            if (company.Employees == null || !company.Employees.Any())
            {
                MessageBox.Show("Employee data is not loaded. Please contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for a matching user
            var employee = company.Employees.Find(x =>
                string.Equals(x.Username, username, StringComparison.OrdinalIgnoreCase) &&
                x.Password == password // Replace with hashed password check in production
            );

            if (employee != null)
            {
                // Successful login
                MyDashboardForm myDashboardForm = new MyDashboardForm(company, username);
                myDashboardForm.ShowDialog();
            }
            else
            {
                // Invalid login
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
