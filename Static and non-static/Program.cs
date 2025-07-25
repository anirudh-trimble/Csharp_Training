class Person
{
    public static int population = 0;

    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        population++; 
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    public static void ShowPopulation()
    {
        Console.WriteLine($"Total people created: {population}");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Anirudh", 23);
        Person p2 = new Person("krishna", 21);

        p1.DisplayInfo();
        p2.DisplayInfo();

        Person.ShowPopulation();

        Console.WriteLine("Accessing static variable: " + Person.population);
    }
}
