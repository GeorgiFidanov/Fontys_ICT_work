using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkTasks
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
        public TaskStatus Status { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public List<Employee> CreatedBy { get; set; } = new List<Employee>();
        public List<Employee> AssignedTo { get; set; } = new List<Employee>();
        [JsonIgnore]
        public Company Company { get; set; }

        public string GetInfo()
        {
            return $"{Name} - {Description}";
        }

        public List<Department> GetDepartments()
        {
            return Departments;
        } 
    }

    public enum TaskStatus
    {
        Open,
        InProgress,
        Completed,
        Blocked,
        Cancelled
    }

}
