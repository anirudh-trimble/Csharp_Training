class Program
{
    static void Main()
    {
        Console.Title = "Console Class Practice";
        Console.WindowHeight = 40;
        Console.WindowWidth = 200;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("This line will not be displayed as it will be cleared in the next line");
        Console.Clear();
        Console.Write("This will print text without a new line. ");
        Console.WriteLine("This will print text with a new line");
        Console.Write("Enter your name: ");
        String name;
        name = Console.ReadLine();
        Console.WriteLine($"Welcome {name} !!");
        Console.WriteLine("Press any key to continue...");
        int inputChar = Console.Read();
        Console.WriteLine($"You entered: {(char)inputChar}");
    }
}
