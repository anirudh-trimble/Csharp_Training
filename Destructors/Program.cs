using System;

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Constructor: MyClass object created.");
    }

    public void SayHello()
    {
        Console.WriteLine("Hello from MyClass!");
    }

    // Destructor
    ~MyClass()
    {
        Console.WriteLine("Destructor: MyClass object is being destroyed.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.SayHello();

        // Forcing garbage collection for demo
        obj = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("End of Main method.");
    }
}
