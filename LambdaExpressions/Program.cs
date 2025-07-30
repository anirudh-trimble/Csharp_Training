internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person{Name = "Bob", Age = 25, City = "London"},
            new Person{Name = "Ani", Age = 25, City = "London"},
            new Person {Name = "Mary", Age = 32, City = "London" },
            new Person {Name = "Whoo", Age = 12, City = "New York" },
            new Person{Name = "Alice", Age = 40, City = "Paris"},
            new Person{Name = "Charlie", Age = 18, City = "New York"}
        };

        var sortedPeople = people.OrderBy(p => p.Age).ThenBy(p => p.Name);
        foreach (var person in sortedPeople)
        {
            Console.WriteLine($"{person.Name} {person.Age}");
        }

        var adults = people.Where(p => p.Age >= 18).OrderBy(p => p.Name);
        Console.WriteLine("\nAdults:");
        foreach (var adult in adults)
        {
            Console.WriteLine($"{adult.Name} {adult.Age}");
        }
        // Group by city
        var groupedByCity = people.GroupBy(p => p.City);
        Console.WriteLine("\nGrouped by City:");
        foreach (var group in groupedByCity)
        {
            Console.WriteLine($"City: {group.Key}");
            foreach (var person in group)
            {
                Console.WriteLine($"  {person.Name} {person.Age}");
            }
        }
        Console.WriteLine("\nAggregation");
        Console.WriteLine($"Total People: {people.Count()}");
        Console.WriteLine($"Youngest person: {people.Min(p => p.Age)}");
        Console.WriteLine($"Are there any minor in the group (Yes / No): ");
        Console.WriteLine(people.Any(p => p.Age < 18) ? "Yes" : "No");
    }
}

public class Person
{
    public String Name { get; set; }
    public int Age { get; set; }
    public String City { get; set; }
}