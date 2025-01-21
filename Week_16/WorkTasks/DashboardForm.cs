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
    public partial class DashboardForm : Form
    {
        private Company company;

        public DashboardForm(Company company)
        {
            InitializeComponent();
            this.company = company;
            PopulateAllTasksListBox();
            PopulateFilterOptions();
        }

        private void PopulateAllTasksListBox()
        {
            UpdateTaskListBox(company.Tasks);
        }

        private void UpdateTaskListBox(IEnumerable<Task> tasks)
        {
            allTaskListBox.Items.Clear();
            foreach (var task in tasks)
            {
                var taskInfo = new StringBuilder();
                taskInfo.AppendLine($"Task ID: {task.TaskId} ");
                taskInfo.AppendLine($"Name: {task.Name} ");
                taskInfo.AppendLine($"Description: {task.Description} ");
                taskInfo.AppendLine($"Status: {task.Status} ");
                taskInfo.AppendLine($"Deadline: {task.Deadline} ");
                taskInfo.AppendLine($"Created By: {string.Join(", ", task.CreatedBy.Select(e => e.FirstName + " " + e.LastName))} ");
                taskInfo.AppendLine($"Assigned To: {string.Join(", ", task.AssignedTo.Select(e => e.FirstName + " " + e.LastName))} ");
                taskInfo.AppendLine($"Departments: {string.Join(", ", task.Departments)}");

                allTaskListBox.Items.Add(taskInfo.ToString());
            }
        }

        private void PopulateFilterOptions()
        {
            // Add empty option for no filter
            statusFilterComboBox.Items.Add("");
            departmentFilterComboBox.Items.Add("");

            // Populate status options
            foreach (TaskStatus status in Enum.GetValues(typeof(TaskStatus)))
            {
                statusFilterComboBox.Items.Add(status);
            }

            // Populate department options
            
            foreach (Department department in Enum.GetValues(typeof(Department)))
            {
                departmentFilterComboBox.Items.Add(department);
            }
        }



        private void applyFiltersButton_Click(object sender, EventArgs e)
        {
            var filteredTasks = company.Tasks.AsEnumerable();

            // Apply title filter
            string titleFilter = filterTextBox.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(titleFilter))
            {
                filteredTasks = filteredTasks.Where(t =>
                    t.Name.ToLower().Contains(titleFilter));
            }

            // Apply status filter
            string statusFilter = statusFilterComboBox.SelectedItem?.ToString() ?? "";
            if (!string.IsNullOrEmpty(statusFilter))
            {
                filteredTasks = filteredTasks.Where(t =>
                    t.Status.ToString() == statusFilter);
            }

            // Apply department filter
            string departmentFilter = departmentFilterComboBox.SelectedItem?.ToString() ?? "";
            Department selectedDepartment;

            foreach (var department in Enum.GetValues(typeof(Department)))
            {
                if (department.ToString() == departmentFilter)
                {
                    selectedDepartment = (Department)department;
                    filteredTasks = filteredTasks.Where(t =>
                    t.Departments.Contains(selectedDepartment));
                }
            }

            // Update ListBox with filtered tasks
            UpdateTaskListBox(filteredTasks);
        }

        private void clearFiltersButton_Click(object sender, EventArgs e)
        {
            filterTextBox.Clear();
            statusFilterComboBox.SelectedIndex = 0;
            departmentFilterComboBox.SelectedIndex = 0;
            PopulateAllTasksListBox();
        }
    }
}
