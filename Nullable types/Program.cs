class Program
{
    static void Main()
    {
        int? age = null;
        double? height = 182.5;
        bool? isStudent = null;

        Console.WriteLine("Age: " + (age.HasValue ? age.Value.ToString() : "No value"));
        Console.WriteLine("Height: " + (height.HasValue ? height.Value.ToString() : "No value"));
        Console.WriteLine("Is Student: " + (isStudent ?? false));  // Using null-coalescing operator

        // Assigning value later
        age = 25;
        Console.WriteLine("\nUpdated Age: " + age);
    }
}
