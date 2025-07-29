using System;

interface IPrinter
{
    void Print();
}

interface IScanner
{
    void Scan();
}

// Implements both interfaces
class MultiFunctionMachine : IPrinter, IScanner
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

class Program
{
    static void Main(string[] args)
    {
        MultiFunctionMachine mfm = new MultiFunctionMachine();
        mfm.Print();  // Output: Printing document...
        mfm.Scan();   // Output: Scanning document...
    }
}
