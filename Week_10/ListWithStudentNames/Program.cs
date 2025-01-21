using System;
using System.Collections.Generic;

class Program
{
    static void AddStudent(string name, string[] studentArray, List<string> studentList)
    {
        // Find the first empty slot in the array
        for (int i = 0; i < studentArray.Length; i++)
        {
            if (studentArray[i] == null)
            {
                studentArray[i] = name;
                break;
            }
        }

        // Add the name to the list
        studentList.Add(name);
    }

    static void Main()
    {
        // Define the size of the array (group)
        int arraySize = 5;
        string[] studentArray = new string[arraySize];
        List<string> studentList = new List<string>();

        // Add student names
        AddStudent("Ben", studentArray, studentList);
        AddStudent("Juul", studentArray, studentList);
        AddStudent("Fatuh", studentArray, studentList);
        AddStudent("Vladi", studentArray, studentList);
        AddStudent("Jojo", studentArray, studentList);

        // Display the students in the array
        Console.WriteLine("Students in array:");
        foreach (var student in studentArray)
        {
            Console.WriteLine(student);
        }

        // Display the students in the list
        Console.WriteLine("\nStudents in list:");
        foreach (var student in studentList)
        {
            Console.WriteLine(student);
        }
    }

}
