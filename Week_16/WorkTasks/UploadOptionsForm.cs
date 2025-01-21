using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Microsoft.Data.SqlClient;

namespace WorkTasks
{
    public partial class UploadOptionsForm : Form
    {
        private Company company;

        public UploadOptionsForm(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Select CSV/JSON File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileExtension = Path.GetExtension(filePath).ToLower();
                    if (fileExtension == ".csv")
                    {
                        LoadEmployeesFromCsv(filePath);
                        MessageBox.Show("Employees loaded successfully from CSV!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (fileExtension == ".json")
                    {
                        LoadTasksFromJson(filePath);
                        MessageBox.Show("Tasks loaded successfully from JSON!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid file format. Please select a CSV or JSON file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        public void LoadEmployeesFromCsv(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1)) // Skip header line
            {
                var values = line.Split(',');
                if (!Enum.TryParse<Department>(values[10].Replace(" ", ""), true, out var department))
                {
                    // Handle invalid department value, e.g., log an error or skip the record
                    continue;
                }
                if (string.IsNullOrWhiteSpace(values[4]) || !Enum.TryParse<Gender>(values[4], true, out var gender))
                {
                    // Handle invalid gender value, e.g., log an error or skip the record
                    continue;
                }
                var employee = new Employee
                {
                    EmployeeId = int.Parse(values[0]),
                    SSN = values[1],
                    FirstName = values[2],
                    LastName = values[3],
                    Gender = gender,
                    StreetName = values[5],
                    StreetNumber = values[6],
                    Zipcode = values[7],
                    City = values[8],
                    Email = values[9],
                    Department = department,
                    Username = values[11],
                    Password = values[12],
                    Company = company
                };
                company.Employees.Add(employee);
            }
        }
        

        public void LoadTasksFromJson(string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]"); // Create an empty JSON array if the file doesn't exist
                return;
            }

            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Converters = { new JsonStringEnumConverter() }
                };

                string json = File.ReadAllText(filePath);
                var loadedTasks = JsonSerializer.Deserialize<List<Task>>(json, options);

                if (loadedTasks != null)
                {
                    // Restore references to Company and Employees
                    foreach (var task in loadedTasks)
                    {
                        task.Company = company;

                        // Restore CreatedBy reference
                        task.CreatedBy = task.CreatedBy?
                            .Select(e => company.Employees.FirstOrDefault(emp => emp.EmployeeId == e.EmployeeId))
                            .Where(e => e != null) // Remove null values
                            .ToList();

                        // Restore AssignedTo references
                        task.AssignedTo = task.AssignedTo?
                            .Select(e => company.Employees.FirstOrDefault(emp => emp.EmployeeId == e.EmployeeId))
                            .Where(e => e != null) // Remove null values
                            .ToList();
                    }

                    company.Tasks = new List<Task>(loadedTasks);
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Error loading tasks: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error loading tasks: {ex.Message}");
            }
        }



        string _connectionString = @"Server=PRUCKO\SQLEXPRESS;Database=CompanyDB;Integrated Security=true;TrustServerCertificate=True;";

        private void DbBtn_Click(object sender, EventArgs e)
        {
            LoadFromDB();
            MessageBox.Show("Information loaded successfully from Database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadFromDB()
        {
            LoadEmployees();
            LoadTasks();
        }



        public void LoadEmployees()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id, SSN, FirstName, LastName, Gender, StreetName, StreetNumber, ZipCode, City, Email, Username, Password, Department FROM Employees";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            // Check for required fields and show a popup if any are missing
                            if (reader.IsDBNull(reader.GetOrdinal("Id")) ||
                                reader.IsDBNull(reader.GetOrdinal("SSN")) ||
                                reader.IsDBNull(reader.GetOrdinal("FirstName")) ||
                                reader.IsDBNull(reader.GetOrdinal("LastName")) ||
                                reader.IsDBNull(reader.GetOrdinal("Gender")) ||
                                reader.IsDBNull(reader.GetOrdinal("StreetName")) ||
                                reader.IsDBNull(reader.GetOrdinal("StreetNumber")) ||
                                reader.IsDBNull(reader.GetOrdinal("ZipCode")) ||
                                reader.IsDBNull(reader.GetOrdinal("City")) ||
                                reader.IsDBNull(reader.GetOrdinal("Email")) ||
                                reader.IsDBNull(reader.GetOrdinal("Username")) ||
                                reader.IsDBNull(reader.GetOrdinal("Password")) ||
                                reader.IsDBNull(reader.GetOrdinal("Department")))
                            {
                                // Show a message box indicating which field is null
                                MessageBox.Show("One or more required fields are missing in the data. Please check the database.",
                                                "Data Error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                continue; // Skip this entry and continue processing the rest
                            }

                            // Add employee to the list if all fields are valid
                            company.Employees.Add(new Employee
                            {
                                EmployeeId = reader.GetInt32(reader.GetOrdinal("Id")),
                                SSN = reader.GetString(reader.GetOrdinal("SSN")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                Gender = (Gender)Enum.Parse(typeof(Gender), reader.GetString(reader.GetOrdinal("Gender"))),
                                StreetName = reader.GetString(reader.GetOrdinal("StreetName")),
                                StreetNumber = reader.GetString(reader.GetOrdinal("StreetNumber")),
                                Zipcode = reader.GetString(reader.GetOrdinal("ZipCode")),
                                City = reader.GetString(reader.GetOrdinal("City")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                Password = reader.GetString(reader.GetOrdinal("Password")),
                                Department = (Department)Enum.Parse(typeof(Department), reader.GetString(reader.GetOrdinal("Department"))),
                            });
                        }
                        catch (Exception ex)
                        {
                            // If an unexpected error occurs, show a message box
                            MessageBox.Show($"An error occurred while processing data: {ex.Message}",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }




        public void LoadTasks()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Tasks";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        company.Tasks.Add(new Task
                        {
                            TaskId = reader.GetInt32(reader.GetOrdinal("TaskId")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Status = (TaskStatus)Enum.Parse(typeof(TaskStatus), reader.GetString(reader.GetOrdinal("Status"))),
                            Description = reader.GetString(reader.GetOrdinal("Description")),
                            Deadline = reader.GetDateTime(reader.GetOrdinal("Deadline")),
                            Departments = reader.GetString(reader.GetOrdinal("Departments"))
                                .Split('|')
                                .Select(d => (Department)Enum.Parse(typeof(Department), d))
                                .ToList(),
                            //CreatedBy = GetEmployeesByNames(reader.GetString(reader.GetOrdinal("CreatedBy"))),
                            //AssignedTo = GetEmployeesByNames(reader.GetString(reader.GetOrdinal("AssignedTo")))
                        });
                    }
                }
            }
        }


    }
}
