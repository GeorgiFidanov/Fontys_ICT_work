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
    public partial class MyDashboardForm : Form
    {
        private Company company;
        private string username;

        public MyDashboardForm(Company company, string username)
        {
            InitializeComponent();
            this.company = company;
            this.username = username;
            PopulateTasks();
        }

        private void PopulateTasks()
        {
            myTasksListBox.Items.Clear();

            var filteredTasks = company.Tasks.AsEnumerable();

            if (!string.IsNullOrEmpty(username))
            {
                filteredTasks = filteredTasks.Where(t =>
                    t.AssignedTo.Any(e => e.Username == username));
            }

            foreach (var task in filteredTasks)
            {
                myTasksListBox.Items.Add(task.GetInfo());
            }
        }

        private void myTasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myTasksListBox.SelectedIndex != -1)
            {
                Task selectedTask = company.Tasks[myTasksListBox.SelectedIndex];
                bool canEdit = false;
                EditTaskForm editTaskForm = new EditTaskForm(company, selectedTask, canEdit);
                editTaskForm.ShowDialog();
                PopulateTasks();
            }
        }
    }
}
