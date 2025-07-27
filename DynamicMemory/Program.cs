using System;

class Student
{
    public string Name;
    public int Age;

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Dynamic memory allocation using 'new'
        Student student1 = new Student();
        student1.Name = "Alice";
        student1.Age = 21;

        Student student2 = new Student
        {
            Name = "Bob",
            Age = 22
        };

        student1.Display();
        student2.Display();

        // Array with dynamic allocation
        int[] numbers = new int[5]; // allocated on heap
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 2;
        }

        Console.WriteLine("Array elements:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        // Dynamic string (also allocated on heap)
        string message = new string('x', 10);
        Console.WriteLine("\nGenerated string: " + message);
    }
}
