using System;

namespace AccessModifiersDemo
{
    class Animal
    {
        public string Name = "Dog";                  // Accessible anywhere
        private int age = 5;                         // Accessible only within Animal
        protected string sound = "Bark";             // Accessible in derived classes
        internal string habitat = "Land";            // Accessible within same project
        protected internal string diet = "Carnivore"; // Accessible in same assembly OR subclass
        private protected string origin = "Wild";    // Same assembly + subclass only

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {age}, Sound: {sound}");
            Console.WriteLine($"Habitat: {habitat}, Diet: {diet}, Origin: {origin}");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"Dog says: {sound}");         // Accessible: protected
            Console.WriteLine($"Diet: {diet}");              // Accessible: protected internal
            Console.WriteLine($"Origin: {origin}");          // Accessible: private protected
            // Console.WriteLine(age); // Not accessible (private)
        }
    }

    class Program
    {
        static void Main()
        {
            Animal animal = new Animal();
            animal.ShowDetails();
            Console.WriteLine(animal.Name);         // public
            Console.WriteLine(animal.habitat);      // internal (same assembly)
            Console.WriteLine(animal.diet);         // protected internal
            // Console.WriteLine(animal.sound);     // protected (not accessible here)
            // Console.WriteLine(animal.origin);    // private protected (not accessible here)

            Dog dog = new Dog();
            dog.Bark();
        }
    }
}
