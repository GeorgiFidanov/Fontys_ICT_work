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
    public partial class RemoveTasksForm : Form
    {
        private Company company;
        private List<Task> tasks;

        public RemoveTasksForm(Company company)
        {
            InitializeComponent();
            this.company = company;
            this.tasks = new List<Task>();
            PopulateTasks();
        }

        private void PopulateTasks()
        {
            availableTasksListBox.Items.Clear();
            tasks.Clear();
            foreach (var task in company.Tasks)
            {
                if (task.Status == TaskStatus.Open)
                {
                    if(task.AssignedTo != null && task.AssignedTo.Any())
                    {
                        availableTasksListBox.Items.Add(task.GetInfo());
                        tasks.Add(task);
                    }                    
                }

                if (task.AssignedTo == null || !task.AssignedTo.Any())
                {
                    availableTasksListBox.Items.Add(task.GetInfo());
                    tasks.Add(task);
                }
            }
        }

        private void removeTaskbtn_Click(object sender, EventArgs e)
        {
            if (availableTasksListBox.SelectedIndex != -1)
            {
                Task selectedTask = tasks[availableTasksListBox.SelectedIndex];
                company.Tasks.Remove(selectedTask);
                PopulateTasks();
            }
            else
            {
                MessageBox.Show("Please select a task to remove.");
            }
            
        }
    }
}
