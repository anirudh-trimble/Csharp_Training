using System;

// 1. Encapsulation
public class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

// 2. Abstraction
public abstract class Animal
{
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Bark");
    }
}

// 3. Inheritance

// Single Inheritance
public class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}

public class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}

// Multilevel Inheritance
public class ElectricCar : Car
{
    public void Charge()
    {
        Console.WriteLine("Electric car charging...");
    }
}

// Hierarchical Inheritance
public class Bike : Vehicle
{
    public void Ride()
    {
        Console.WriteLine("Bike is riding");
    }
}

// Multiple Inheritance via Interfaces
public interface IPrintable
{
    void Print();
}

public interface IScannable
{
    void Scan();
}

public class PrinterScanner : IPrintable, IScannable
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

// Is-A and Has-A relationship

// Has-A
public class Engine
{
    public void Run()
    {
        Console.WriteLine("Engine running...");
    }
}

public class Truck
{
    private Engine engine = new Engine(); // Has-A

    public void StartTruck()
    {
        engine.Run();
        Console.WriteLine("Truck started");
    }
}

// MAIN
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Encapsulation");
        var account = new BankAccount();
        account.Deposit(1000);
        Console.WriteLine("Balance: " + account.GetBalance());

        Console.WriteLine("\nAbstraction");
        Animal dog = new Dog();
        dog.MakeSound();

        Console.WriteLine("\nInheritance");
        var car = new Car();
        car.Start(); // from Vehicle
        car.Drive(); // own method

        var eCar = new ElectricCar();
        eCar.Start();
        eCar.Drive();
        eCar.Charge();

        var bike = new Bike();
        bike.Start();
        bike.Ride();

        Console.WriteLine("\nMultiple Inheritance via Interfaces");
        var ps = new PrinterScanner();
        ps.Print();
        ps.Scan();

        Console.WriteLine("\nHas-A (Composition)");
        var truck = new Truck();
        truck.StartTruck();
    }
}
