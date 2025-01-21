using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WorkTasks
{
    public partial class NewTaskForm : Form
    {
        private Company company;

        public NewTaskForm(Company company)
        {
            InitializeComponent();
            this.company = company;
            PopulateEmployeeDropdowns();
        }

        private void PopulateEmployeeDropdowns()
        {
            // Populate the "By" dropdown with all employees
            byCheckedListBox.Items.AddRange(company.Employees.Select(e => $"{e.FirstName} {e.LastName}").ToArray());

            // Populate the "Assign to" dropdown with employees from selected departments
            foreach (var department in Enum.GetValues(typeof(Department)))
            {
                departmentCheckedListBox.Items.Add(department);
            }
            departmentCheckedListBox.ItemCheck += DepartmentCheckedListBox_ItemCheck;

            foreach (var status in Enum.GetValues(typeof(TaskStatus)))
            {
                statusComboBox.Items.Add(status);
            }
            statusComboBox.SelectedIndex = 0;
        }

        private List<Department> EmptyDepatments()
        {
            List<Department> departments = new List<Department>();
            foreach (Department department in Enum.GetValues(typeof(Department)))
            {
                departments.Add(department);
            }
            foreach (Task task in company.Tasks)
            {
                foreach (Department item in task.Departments)
                {

                    departments.Remove(item);
                    
                }
            }
            return departments;

        }



        private void DepartmentCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Event handler -> Update the "Assign to" dropdown based on selected departments
            var selectedDepartments = departmentCheckedListBox.CheckedItems.Cast<Department>().ToList();
            if (e.NewValue == CheckState.Checked)
            {
                selectedDepartments.Add((Department)departmentCheckedListBox.Items[e.Index]);
            }
            else
            {
                selectedDepartments.Remove((Department)departmentCheckedListBox.Items[e.Index]);
            }

            assignToCheckedListBox.Items.Clear();
            var employeesInSelectedDepartments = company.Employees
                .Where(emp => selectedDepartments.Contains(emp.Department))
                .Select(emp => $"{emp.FirstName} {emp.LastName}")
                .ToArray();
            assignToCheckedListBox.Items.AddRange(employeesInSelectedDepartments);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var newTask = new Task
            {
                TaskId = company.Tasks.Count + 1,
                Name = taskTextBox.Text,
                Departments = departmentCheckedListBox.CheckedItems.Cast<Department>().ToList(),
                Status = TaskStatus.Open,
                Description = descriptionTextBox.Text,
                Deadline = deadlineDateTimePicker.Value,

                // Get all checked items from byCheckedListBox
                CreatedBy = company.Employees.Where(
                    e => byCheckedListBox.CheckedItems.Cast<string>().Any(
                        item => item == $"{e.FirstName} {e.LastName}")).ToList(),

                // Get all checked items from assignToCheckedListBox
                AssignedTo = company.Employees.Where(
                    e => assignToCheckedListBox.CheckedItems.Cast<string>().Any(
                        item => item == $"{e.FirstName} {e.LastName}")).ToList(),

                Company = company
            };

            if (string.IsNullOrWhiteSpace(taskTextBox.Text))
            {
                MessageBox.Show("Task name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (departmentCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("At least one department must be selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                MessageBox.Show("Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (byCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("You must select at least one person from the 'By' list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            company.FindById(newTask);
            this.Close();
        }
    }
}
