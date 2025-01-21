using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkTasks
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Department Department { get; set; }
        [JsonIgnore]
        public List<Task> Tasks { get; set; } = new List<Task>();
        [JsonIgnore]
        public Company Company { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
