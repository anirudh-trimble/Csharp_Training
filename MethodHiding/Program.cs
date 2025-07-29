using System;

class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public new void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Speak();  // Output: Dog barks

        Animal a = new Dog();
        a.Speak();  // Output: Animal speaks (method hiding!)
    }
}
