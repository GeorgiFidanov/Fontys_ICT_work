internal class Program
{
    public static int LenthInput()
    {
        Console.Write("Enter the amount of random characters you want:");
        string input = Console.ReadLine();

        int size;

        if (!int.TryParse(input, out size) || size <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
            return LenthInput();
        }
        return size;
    }

    public static string AsciiRand()
    {
        Random rand = new Random();
        int num = rand.Next(33, 126);
        char character = (char)num;
        return character.ToString();
    }

    private static void Main(string[] args)
    {
        int size = LenthInput();
        string[] characters = new string[size];
        for (int  i= 0;  i < characters.Length; i++)
        {
            characters[i] = AsciiRand();
        }

        Console.WriteLine("Random characters: ");
        foreach (string character in characters)
        {
            Console.Write(character + "\n");
        }
    }
}
