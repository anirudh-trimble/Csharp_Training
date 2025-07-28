using System;
using System.Threading;

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("MyClass object created");
    }

    ~MyClass()
    {
        Console.WriteLine("MyClass object destroyed");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj = null;

        // Force garbage collection
        GC.Collect();
        GC.WaitForPendingFinalizers(); // Make sure all finalizers have run

        Console.WriteLine("End of Main");
    }
}
