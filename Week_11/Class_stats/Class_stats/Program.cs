using System;
using System.Collections.Generic;
using System.Linq;
using Class_stats;

class Program
{
    public static readonly Dictionary<string, int> GradeMapping = new Dictionary<string, int>
    {
        { "U", 20 },
        { "S", 50 },
        { "G", 23 },
        { "O", 7 }
    };

    static void Main(string[] args)
    {
        // Initialize the class list
        List<Student> classMembers = new List<Student>
        {
            new Student { Name = "Jojo" }
        };

        while (true)
        {
            Console.WriteLine("\nClass Management System");
            Console.WriteLine("1. View All Students and Grades");
            Console.WriteLine("2. Add a Student to the Class");
            Console.WriteLine("3. Add Grade to a Student");
            Console.WriteLine("4. View Class Statistics");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. Remove a Student");
            Console.WriteLine("7. Edit Grades of a Student");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            string? input = Console.ReadLine();
            string choice = input ?? "Undef case";

            switch (choice)
            {
                case "1":
                    ViewStudents(classMembers);
                    break;
                case "2":
                    AddStudent(classMembers);
                    break;
                case "3":
                    Console.Write("\nEnter the student's name: ");
                    string? new_name = Console.ReadLine();
                    string name = new_name ?? "Unnamed Student"; // Default to "Unnamed Student" if input is null
                    AddGrade(classMembers, name);
                    break;
                case "4":
                    ViewStatistics(classMembers);
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                case "6":
                    RemoveStudent(classMembers);
                    break;
                case "7":
                    EditGrades(classMembers);
                    break;
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

    static void AddStudent(List<Student> students)
    {
        Console.Write("\nEnter the student's name: ");

        string? input = Console.ReadLine();
        string name = input ?? "Unnamed Student"; // Default to "Unnamed Student" if input is null

        if (students.Any(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Student already in class!");
        }
        else
        {
            var student = new Student { Name = name };
            students.Add(student);
            Console.WriteLine($"Student {name} added to the class.");
        }
    }

    static void AddGrade(List<Student> students, string name)
    {
        var student = students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (student != null)
        {
            Console.WriteLine("Available grades: U, S, G, O");
            Console.Write("Enter the grade to add: ");
            string grade = Console.ReadLine()?.ToUpper() ?? string.Empty;

            if (GradeMapping.ContainsKey(grade))
            {
                student.Grades.Add(grade);
                Console.WriteLine($"Grade {grade} added to {student.Name}.");
            }
            else
            {
                Console.WriteLine("Invalid grade. Please enter one of the available grades (U, S, G, O).");
            }
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void RemoveStudent(List<Student> students)
    {
        Console.Write("\nEnter the student's name to remove: ");
        string? input = Console.ReadLine();
        string name = input ?? "Unnamed Student";

        var student = students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine($"Student {name} has been removed.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void EditGrades(List<Student> students)
    {
        Console.Write("\nEnter the student's name to edit grades: ");
        string? input = Console.ReadLine();
        string name = input ?? "Unnamed Student";

        var student = students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (student != null)
        {
            Console.WriteLine($"Current grades for {student.Name}: {string.Join(", ", student.Grades)}");
            Console.WriteLine("1. Add a grade");
            Console.WriteLine("2. Remove a grade");

            Console.Write("Enter your choice: ");
            string? choiceInput = Console.ReadLine();
            string choice = choiceInput ?? "0";

            switch (choice)
            {
                case "1":
                    AddGrade(new List<Student> { student }, name); // Reuse the AddGrade function
                    break;
                case "2":
                    Console.WriteLine("Enter the grade to remove:");
                    string gradeToRemove = Console.ReadLine()?.ToUpper() ?? string.Empty;

                    if (student.Grades.Remove(gradeToRemove))
                    {
                        Console.WriteLine($"Grade {gradeToRemove} removed from {student.Name}.");
                    }
                    else
                    {
                        Console.WriteLine($"Grade {gradeToRemove} not found.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
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
