using System;

class Program
{
    static void Main()
    {
        int numberOfPersons;
        while (true)
        {
            Console.Write("How many persons do you want to register? ");
            if (int.TryParse(Console.ReadLine(), out numberOfPersons) && numberOfPersons > 0)
            {
                break;
            }
            Console.WriteLine("Please enter a valid positive number.");
        }

        string[] names = new string[numberOfPersons];
        int[] ages = new int[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            // \x1b[1m will print it in bold. \x1b[0m at the end is used to reset the formatting
            Console.Write($"Enter the \x1b[1m name \x1b[0m of person {i + 1}: ");
            names[i] = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write($"Enter the age of person {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                {
                    ages[i] = age;
                    break;
                }
                Console.WriteLine("Please enter a valid positive age.");
            }
        }

        Console.WriteLine("\nRegistered Persons:");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"Person {i + 1}: Name = {names[i]}, Age = {ages[i]}");
        }
    }
}
