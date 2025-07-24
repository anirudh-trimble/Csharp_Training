class Program
{
    enum DaysOfWeek
    {
        Sunday,
        Monday, 
        Tuesday, 
        Wednesday, 
        Friday,
        Saturday
    }
    static void Main(string[] args)
    {
        int age = 23;
        double height = 182.5;
        float weight = 70.5f;
        char grade = 'A';
        string name = "Ani";
        bool isStudent = false;
        decimal price = 99.99m;

        DaysOfWeek today = DaysOfWeek.Wednesday;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Weight: {weight}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Is Student: {isStudent}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Today is: {today}");
    }
}