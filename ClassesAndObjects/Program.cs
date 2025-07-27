using System;

namespace ClassAndObjectsDemo
{
    // Define a class
    public class Car
    {
        // Fields (data members)
        public string Brand;
        public string Model;
        public int Year;

        // Method
        public void DisplayDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create objects (instances of the Car class)
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Model = "Camry";
            car1.Year = 2020;

            Car car2 = new Car();
            car2.Brand = "Tesla";
            car2.Model = "Model S";
            car2.Year = 2023;

            // Call method on each object
            car1.DisplayDetails();
            car2.DisplayDetails();
        }
    }
}
