using System;

namespace AbstractandInterface
{
    // Interface definition
    interface IDriveable
    {
        void Drive();
    }

    // Abstract class definition
    abstract class Vehicle
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public void ShowBrand()
        {
            Console.WriteLine($"Brand: {Brand}");
        }

        // Abstract method (must be implemented by derived class)
        public abstract void Honk();
    }

    // Concrete class implementing interface and inheriting abstract class
    class Car : Vehicle, IDriveable
    {
        public Car(string brand) : base(brand) { }

        public override void Honk()
        {
            Console.WriteLine("Car horn: Beep Beep!");
        }

        public void Drive()
        {
            Console.WriteLine("Car is being driven.");
        }
    }

    class Program
    {
        static void Main()
        {
            Car myCar = new Car("Toyota");
            myCar.ShowBrand();   // From abstract class
            myCar.Honk();        // Override abstract method
            myCar.Drive();       // From interface

        }
    }
}
