using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WorkTasks
{
    public partial class UpdateTaskForm : Form
    {
        private Company company;

        public UpdateTaskForm(Company company)
        {
            InitializeComponent();
            this.company = company;
            PopulateTasks();
        }

        private void PopulateTasks()
        {
            allTasksListBox.Items.Clear();
            foreach (var task in company.Tasks)
            {
                allTasksListBox.Items.Add(task.GetInfo());
            }
        }

        private void allTasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allTasksListBox.SelectedIndex != -1)
            {
                Task selectedTask = company.Tasks[allTasksListBox.SelectedIndex];
                bool canEdit = true;
                EditTaskForm editTaskForm = new EditTaskForm(company, selectedTask, canEdit);
                editTaskForm.ShowDialog();
                PopulateTasks();
            }
        }
    }
}
