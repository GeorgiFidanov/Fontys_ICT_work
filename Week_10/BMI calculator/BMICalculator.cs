using System;

class BMICalculator
{
    static decimal GetValidInput()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (input != null)
            {
                input = input.Replace(',', '.');
                if (decimal.TryParse(input, out decimal result) && result > 0)
                    return result;
            }
            Console.Write("Invalid input. Please enter a positive number: ");
        }
    }

    static string GetBMIStatus(decimal bmi)
    {
        if (bmi < 18.5m)
            return "Your BMI status is: Underweight";
        else if (bmi < 25m)
            return "Your BMI status is: Normal weight";
        else if (bmi < 30m)
            return "Your BMI status is: Overweight";
        else
            return "Your BMI status is: Obese";
    }

    static void Main(string[] args)
    {
        Console.WriteLine("BMI Calculator");

        Console.Write("Enter your weight in kg: ");
        decimal weight = GetValidInput();

        Console.Write("Enter your height in meters: ");
        decimal height = GetValidInput();

        decimal bmi = weight / (height * height);

        Console.WriteLine($"Your BMI is: {bmi:F2}");

        string bmiStatus = GetBMIStatus(bmi);
        Console.WriteLine(bmiStatus);
    }
}
