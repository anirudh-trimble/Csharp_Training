using System;

public class Person
{
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get; }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // This is a method that returns a new object with updated values
    public Person WithAge(int newAge)
    {
        return new Person(this.FirstName, this.LastName, newAge);
    }
}

class Program
{
    static void Main()
    {
        var person1 = new Person("John", "Doe", 30);
        Console.WriteLine($"Name: {person1.FirstName} {person1.LastName}, Age: {person1.Age}");

        // person1.Age = 35; not possible, as Age is read-only.

        // But we can create a new person using the already existing object but with a modified age.
        var person2 = person1.WithAge(35);
        Console.WriteLine($"Updated Age: {person2.Age}");
    }
}
