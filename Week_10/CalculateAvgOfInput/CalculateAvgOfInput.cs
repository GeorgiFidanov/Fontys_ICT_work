using System;
using System.Globalization;

class AvrOfInput
{
    static double ParseInput(string input)
    {
        input = input.Replace(',', '.');
        return double.Parse(input, CultureInfo.InvariantCulture);
    }

    static void Main()
    {
        int count = 0;
        double sum = 0;
        while (true)
        {
            Console.Write("Please input a number or $: ");
            string answer = Console.ReadLine();
            if (answer == "$")
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"The average is: {sum/count :F2} ");
                Console.WriteLine("--------------------------------");
                break;
            }
            double number = ParseInput(answer);
            sum += number;
            count++;
        }
    }
}
