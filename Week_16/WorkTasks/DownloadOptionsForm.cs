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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Microsoft.Data.SqlClient;

namespace WorkTasks
{
    public partial class DownloadOptionsForm : Form
    {
        private Company company;
        public DownloadOptionsForm(Company company)
        {
            InitializeComponent();
            this.company = company;
        }


        private void JSONBtn_Click(object sender, EventArgs e)
        {
            SaveTasksToJson();
        }

        public void SaveTasksToJson()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string defaultFileName = $"data_{DateTime.Now:yyyy-MM-dd}.json";
                saveFileDialog.FileName = defaultFileName;
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var options = new JsonSerializerOptions
                        {
                            WriteIndented = true,
                            Converters = { new JsonStringEnumConverter() }
                        };

                        // Sort tasks by TaskId for consistent ordering
                        var sortedTasks = company.Tasks.OrderBy(t => t.TaskId).ToList();

                        // Save all tasks
                        var json = JsonSerializer.Serialize(sortedTasks, options);
                        File.WriteAllText(saveFileDialog.FileName, json);

                        MessageBox.Show("Tasks successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void CSVBtn_Click(object sender, EventArgs e)
        {
            SaveTasksToCsv();
        }

        public void SaveTasksToCsv()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string defaultFileName = $"data_{DateTime.Now:yyyy-MM-dd}.csv";
                saveFileDialog.FileName = defaultFileName;
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportAllDataToCsv(defaultFileName);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExportTasksOnlyToCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write tasks header
                writer.WriteLine("TaskId,Name,Status,Description,Deadline,Departments,CreatedBy,AssignedTo");

                // Write tasks data
                foreach (var task in company.Tasks)
                {
                    string departments = string.Join("|", task.Departments);
                    string createdBy = string.Join("|", task.CreatedBy?.Select(e => $"{e.FirstName} {e.LastName}") ?? Array.Empty<string>());
                    string assignedTo = string.Join("|", task.AssignedTo?.Select(e => $"{e.FirstName} {e.LastName}") ?? Array.Empty<string>());

                    writer.WriteLine($"{task.TaskId},{EscapeCsvField(task.Name)},{task.Status}," +
                                   $"{EscapeCsvField(task.Description)},{task.Deadline:dd/MM/yyyy h:mm:ss tt}," +
                                   $"{EscapeCsvField(departments)},{EscapeCsvField(createdBy)},{EscapeCsvField(assignedTo)}");
                }
            }
        }

        private void ExportAllDataToCsv(string filePath)
        {
            string directory = Path.GetDirectoryName(filePath);
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(filePath);

            // Export employees
            string employeesFile = Path.Combine(directory, $"{fileNameWithoutExt}_employees.csv");
            using (StreamWriter writer = new StreamWriter(employeesFile))
            {
                // Write employees header
                writer.WriteLine("id,ssn,first_name,last_name,gender,street_name,street_number,zipcode,city,email,Department,Username,Password");

                // Write employees data
                foreach (var employee in company.Employees)
                {
                    string username = (employee.FirstName.Substring(0, 1) + employee.LastName)
                        .ToLower()
                        .Replace(" ", "")
                        .Replace("'", "")
                        .Replace("-", "");
                    string password = employee.SSN.Substring(employee.SSN.Length - 4) + "123";

                    writer.WriteLine(
                        $"{employee.EmployeeId},{employee.SSN}," +
                        $"{EscapeCsvField(employee.FirstName)},{EscapeCsvField(employee.LastName)}," +
                        $"{employee.Gender},{EscapeCsvField(employee.StreetName)},{employee.StreetNumber}," +
                        $"{employee.Zipcode},{EscapeCsvField(employee.City)},{employee.Email}," +
                        $"{employee.Department},{username},{password}");
                }
            }

            // Export tasks
            string tasksFile = Path.Combine(directory, $"{fileNameWithoutExt}_tasks.csv");
            ExportTasksOnlyToCsv(tasksFile);
        }

        private string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field)) return "";
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
            {
                return $"\"{field.Replace("\"", "\"\"")}\"";
            }
            return field;
        }


        public void AddUsernamesAndPasswords(string filePath)
        {
            // Input CSV file path
            string inputFilePath = filePath;
            string outputFilePath = "employees_with_login.csv";

            // Read all lines from the CSV file
            var lines = File.ReadAllLines(inputFilePath).ToList();

            // Add the new header with Username and Password
            if (lines.Count > 0)
            {
                lines[0] += ",Username,Password"; // Append new fields to the header
            }

            // Process each line (skip the header)
            for (int i = 1; i < lines.Count; i++)
            {
                var values = lines[i].Split(',');

                // Generate Username: first letter of first name + last name (lowercase, without spaces)
                string firstName = values[2].Trim(); // first_name
                string lastName = values[3].Trim();  // last_name
                string username = (firstName.Substring(0, 1) + lastName).ToLower().Replace(" ", "");

                // Generate a default Password (e.g., last 4 digits of SSN + "123")
                string ssn = values[1].Trim(); // SSN
                string password = ssn.Substring(ssn.Length - 4) + "123";

                // Append Username and Password to the line
                lines[i] += $",{username},{password}";
            }

            // Save the updated data to a new CSV file
            File.WriteAllLines(outputFilePath, lines);

            Console.WriteLine($"Updated CSV file saved to: {outputFilePath}");
        }

        string _connectionString = @"Server=PRUCKO\SQLEXPRESS;Database=CompanyDB;Integrated Security=true;TrustServerCertificate=True;";


        private void DbBtn_Click(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void LoadDB()
        {
            SaveEmployees();
            SaveTasks();

        }

        public void SaveEmployees()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    foreach (var employee in company.Employees)
                    {
                        string query = @"
                IF EXISTS (SELECT 1 FROM Employees WHERE SSN = @SSN)
                BEGIN
                    UPDATE Employees
                    SET FirstName = @FirstName, 
                        LastName = @LastName, 
                        Gender = @Gender, 
                        StreetName = @StreetName, 
                        StreetNumber = @StreetNumber, 
                        Zipcode = @Zipcode, 
                        City = @City, 
                        Email = @Email, 
                        Username = @Username, 
                        Password = @Password, 
                        Department = @Department
                    WHERE SSN = @SSN
                END
                ELSE
                BEGIN
                    INSERT INTO Employees (
                        FirstName, LastName, Gender, StreetName, StreetNumber, 
                        Zipcode, City, Email, Username, Password, Department, SSN
                    )
                    VALUES (
                        @FirstName, @LastName, @Gender, @StreetName, @StreetNumber, 
                        @Zipcode, @City, @Email, @Username, @Password, @Department, @SSN
                    )
                END";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SSN", string.IsNullOrEmpty(employee.SSN) ? DBNull.Value : employee.SSN);
                            command.Parameters.AddWithValue("@FirstName", string.IsNullOrEmpty(employee.FirstName) ? DBNull.Value : employee.FirstName);
                            command.Parameters.AddWithValue("@LastName", string.IsNullOrEmpty(employee.LastName) ? DBNull.Value : employee.LastName);
                            command.Parameters.AddWithValue("@Gender", employee.Gender.ToString()); // Convert enum to string
                            command.Parameters.AddWithValue("@StreetName", string.IsNullOrEmpty(employee.StreetName) ? DBNull.Value : employee.StreetName);
                            command.Parameters.AddWithValue("@StreetNumber", string.IsNullOrEmpty(employee.StreetNumber) ? DBNull.Value : employee.StreetNumber);
                            command.Parameters.AddWithValue("@Zipcode", string.IsNullOrEmpty(employee.Zipcode) ? DBNull.Value : employee.Zipcode);
                            command.Parameters.AddWithValue("@City", string.IsNullOrEmpty(employee.City) ? DBNull.Value : employee.City);
                            command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(employee.Email) ? DBNull.Value : employee.Email);
                            command.Parameters.AddWithValue("@Username", string.IsNullOrEmpty(employee.Username) ? DBNull.Value : employee.Username);
                            command.Parameters.AddWithValue("@Password", string.IsNullOrEmpty(employee.Password) ? DBNull.Value : employee.Password);
                            command.Parameters.AddWithValue("@Department", employee.Department.ToString()); // Convert enum to string

                            command.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Employees saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving employees: {ex.Message}");
                throw;
            }
        }



        public void SaveTasks()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                foreach (var task in company.Tasks)
                {
                    string query = @"
                IF EXISTS (SELECT 1 FROM Tasks WHERE TaskId = @TaskId)
                UPDATE Tasks
                SET Name = @Name, Status = @Status, Description = @Description, Deadline = @Deadline, 
                    Departments = @Departments, CreatedBy = @CreatedBy, AssignedTo = @AssignedTo
                WHERE TaskId = @TaskId
                ELSE
                INSERT INTO Tasks (Name, Status, Description, Deadline, Departments, CreatedBy, AssignedTo)
                VALUES (@Name, @Status, @Description, @Deadline, @Departments, @CreatedBy, @AssignedTo)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaskId", task.TaskId);
                        command.Parameters.AddWithValue("@Name", task.Name);
                        command.Parameters.AddWithValue("@Status", task.Status.ToString());
                        command.Parameters.AddWithValue("@Description", task.Description);
                        command.Parameters.AddWithValue("@Deadline", task.Deadline);
                        command.Parameters.AddWithValue("@Departments", string.Join("|", task.Departments));
                        command.Parameters.AddWithValue("@CreatedBy", string.Join("|", task.CreatedBy.Select(e => $"{e.FirstName} {e.LastName}")));
                        command.Parameters.AddWithValue("@AssignedTo", string.Join("|", task.AssignedTo.Select(e => $"{e.FirstName} {e.LastName}")));
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
