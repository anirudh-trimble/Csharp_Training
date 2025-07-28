using System;

namespace ConstructorsDemo
{
    public class Car
    {
        // Fields
        public string Brand;
        public string Model;
        public int Year;

        // Static field
        public static int CarCount;

        // 1. Default Constructor
        public Car()
        {
            Brand = "DefaultBrand";
            Model = "DefaultModel";
            Year = 2000;
            CarCount++;
        }

        // 2. Parameterized Constructor
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
            CarCount++;
        }

        // 3. Static Constructor (runs only once)
        static Car()
        {
            Console.WriteLine("Static constructor called. Initializing static data...");
            CarCount = 0;
        }

        // 4. Method to display car info
        public void Display()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }
    }

    // 5. Class with Private Constructor (Singleton pattern style)
    public class Database
    {
        private static Database _instance;

        // Private constructor
        private Database()
        {
            Console.WriteLine("Database connection created.");
        }

        // Static method to get instance
        public static Database GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using default constructor
            Car car1 = new Car();
            car1.Display();

            // Using parameterized constructor
            Car car2 = new Car("Tesla", "Model 3", 2022);
            car2.Display();

            // Showing use of static field
            Console.WriteLine($"Total cars created: {Car.CarCount}");

            // Using private constructor via static method
            Database db1 = Database.GetInstance();
            Database db2 = Database.GetInstance();

            // db1 and db2 point to the same object
            Console.WriteLine($"Are both db instances same? {db1 == db2}");
        }
    }
}
