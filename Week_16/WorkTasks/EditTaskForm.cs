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
    public partial class EditTaskForm : Form
    {
        private Company company;
        private Task selectedTask;
        public bool canEdit;

        public EditTaskForm(Company company, Task task, bool canEdit)
        {
            InitializeComponent();
            this.company = company;
            this.selectedTask = task;
            this.canEdit = canEdit;
            PopulateFields();
            SetEditableFields();
        }

        private void PopulateFields()
        {
            // Assuming you have text boxes or labels for these fields
            nameTextBox.Text = selectedTask.Name;
            descriptionTextBox.Text = selectedTask.Description;
            deadlineDateTimePicker.Value = selectedTask.Deadline;
            byCheckedListBox.Items.AddRange(company.Employees.Select(e => e.FirstName + " " + e.LastName).ToArray());
            assignToCheckedListBox.Items.AddRange(company.Employees.Select(e => e.FirstName + " " + e.LastName).ToArray());
            departmentCheckedListBox.Items.AddRange(Enum.GetNames(typeof(Department)));
            statusComboBox.DataSource = Enum.GetValues(typeof(TaskStatus));

            // Set the current values
            statusComboBox.SelectedItem = selectedTask.Status;
            foreach (var employee in selectedTask.CreatedBy)
            {
                for (int i = 0; i < byCheckedListBox.Items.Count; i++)
                {
                    if (byCheckedListBox.Items[i].ToString() == employee.FirstName + " " + employee.LastName)
                    {
                        byCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            foreach (var employee in selectedTask.AssignedTo)
            {
                for (int i = 0; i < assignToCheckedListBox.Items.Count; i++)
                {
                    if (assignToCheckedListBox.Items[i].ToString() == employee.FirstName + " " + employee.LastName)
                    {
                        assignToCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            foreach (var department in selectedTask.Departments)
            {
                for (int i = 0; i < departmentCheckedListBox.Items.Count; i++)
                {
                    if (departmentCheckedListBox.Items[i].ToString() == department.ToString())
                    {
                        departmentCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void SetEditableFields()
        {
            // Make all fields read-only except statusComboBox and assignToCheckedListBox
            nameTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            deadlineDateTimePicker.Enabled = false;
            byCheckedListBox.Enabled = false;
            departmentCheckedListBox.Enabled = false;

            // Enable editing for statusComboBox and assignToCheckedListBox
            statusComboBox.Enabled = true;
            assignToCheckedListBox.Enabled = canEdit;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Update the task status and assigned employees
            selectedTask.Status = (TaskStatus)statusComboBox.SelectedItem;
            selectedTask.AssignedTo = company.Employees
                .Where(e => assignToCheckedListBox.CheckedItems.Contains(e.FirstName + " " + e.LastName))
                .ToList();

            company.FindById(selectedTask);

            MessageBox.Show("Task updated successfully!");
            this.Close();
        }
    }
}
