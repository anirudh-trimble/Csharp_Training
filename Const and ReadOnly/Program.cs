class ConstantsExample
{
    // const: compile-time constant
    public const double Pi = 3.14159;

    // readonly: runtime constant
    public readonly int Id;

    public ConstantsExample(int id)
    {
        Id = id; // Readonly can be initialzed in constructor
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Pi: {Pi}");
        Console.WriteLine($"ID: {Id}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ConstantsExample obj1 = new ConstantsExample(101);
        ConstantsExample obj2 = new ConstantsExample(202);

        obj1.ShowDetails();
        obj2.ShowDetails();
    }
}
