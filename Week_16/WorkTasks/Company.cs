using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace WorkTasks
{
    public class Company
    {
        //public string Name { get; set; }
        //public string Address { get; set; }
        //public string City { get; set; }
        //public string Zipcode { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public void FindById(Task task)
        {
            var existingTask = Tasks.FirstOrDefault(t => t.TaskId == task.TaskId);
            if (existingTask != null)
            {
                // Update existing task
                existingTask.Name = task.Name;
                existingTask.Departments = task.Departments;
                existingTask.Status = task.Status;
                existingTask.Description = task.Description;
                existingTask.Deadline = task.Deadline;
                existingTask.CreatedBy = task.CreatedBy?.ToList();
                existingTask.AssignedTo = task.AssignedTo?.ToList();
                existingTask.Company = this;
            }
            else
            {
                task.Company = this;
                Tasks.Add(task);
            }
        }
    }
}
