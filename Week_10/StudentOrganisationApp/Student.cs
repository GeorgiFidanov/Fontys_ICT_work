public class Student
{
    public string Name { get; set; }
    public List<int> Grades { get; set; } = new List<int>();

    public double AverageGrade => Grades.Count > 0 ? Grades.Average() : 0;
    public bool Passed => AverageGrade >= 50; // Example passing threshold
}

using System;
}using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the class list
        List<Student> classMembers = new List<Student>
        {
            new Student { Name = "Alice" },
            new Student { Name = "Bob" },
            new Student { Name = "Charlie" }
        };

        while (true)
        {
            Console.WriteLine("\nClass Management System");
            Console.WriteLine("1. View All Students and Grades");
            Console.WriteLine("2. Add Grade to a Student");
            Console.WriteLine("3. View Class Statistics");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewStudents(classMembers);
                    break;
                case "2":
                    AddGrade(classMembers);
                    break;
                case "3":
                    ViewStatistics(classMembers);
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ViewStudents(List<Student> students)
    {
        Console.WriteLine("\nClass Members and Grades:");
        foreach (var student in students)
        {
            string grades = student.Grades.Count > 0 ? string.Join(", ", student.Grades) : "No grades yet";
            Console.WriteLine($"- {student.Name}: {grades} (Average: {student.AverageGrade:F2})");
        }
    }

    static void AddGrade(List<Student> students)
    {
        Console.Write("\nEnter the student's name: ");
        string name = Console.ReadLine();
        var student = students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (student != null)
        {
            Console.Write("Enter the grade to add: ");
            if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
            {
                student.Grades.Add(grade);
                Console.WriteLine($"Grade {grade} added to {student.Name}.");
            }
            else
            {
                Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void ViewStatistics(List<Student> students)
    {
        Console.WriteLine("\nClass Statistics:");
        int totalStudents = students.Count;
        int studentsPassed = students.Count(s => s.Passed);
        int studentsFailed = totalStudents - studentsPassed;

        Console.WriteLine($"Total Students: {totalStudents}");
        Console.WriteLine($"Students Passed: {studentsPassed}");
        Console.WriteLine($"Students Failed: {studentsFailed}");

        if (students.Any(s => s.Grades.Count > 0))
        {
            double averageClassGrade = students.Where(s => s.Grades.Count > 0)
                                               .Average(s => s.AverageGrade);
            Console.WriteLine($"Class Average Grade: {averageClassGrade:F2}");
        }
        else
        {
            Console.WriteLine("No grades available for statistical analysis.");
        }
    }
}
