using System;
using System.Globalization;

class BasicCalculator
{
    static double ParseInput(string input)
    {
        // Replace comma with dot to handle both decimal separators
        input = input.Replace(',', '.');
        return double.Parse(input, CultureInfo.InvariantCulture);
    }

    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = ParseInput(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = ParseInput(Console.ReadLine());

        Console.Write("Enter operator (+ - * /): ");
        string operatorChosen = Console.ReadLine();

        if (operatorChosen == "+")
        {
            Console.WriteLine(num1 + " " + operatorChosen + " " + num2 + " = " + (num1 + num2));
        }
        else if (operatorChosen == "-")
        {
            Console.WriteLine(num1 + " " + operatorChosen + " " + num2 + " = " + (num1 - num2));
        }
        else if (operatorChosen == "*")
        {
            Console.WriteLine(num1 + " " + operatorChosen + " " + num2 + " = " + (num1 * num2));
        }
        else if (operatorChosen == "/")
        {
            Console.WriteLine(num1 + " " + operatorChosen + " " + num2 + " = " + (num1 / num2));
        }
        else
        {
            Console.WriteLine("Invalid operator");
        }
    }


}
