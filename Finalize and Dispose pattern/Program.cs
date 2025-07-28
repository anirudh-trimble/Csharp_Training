using System;

class MyResource : IDisposable
{
    private bool disposed = false;

    // Simulate unmanaged resource
    private IntPtr unmanagedResource;

    public MyResource()
    {
        Console.WriteLine("Resource acquired.");
        // Simulate allocation of unmanaged memory
        unmanagedResource = new IntPtr(123);
    }

    // Finalizer (destructor)
    ~MyResource()
    {
        Dispose(false);
    }

    // Public Dispose method
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this); // Prevent finalizer from running
    }

    // Core dispose logic
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Free managed resources here
                Console.WriteLine("Releasing managed resources...");
            }

            // Free unmanaged resources here
            Console.WriteLine("Releasing unmanaged resources...");
            unmanagedResource = IntPtr.Zero;

            disposed = true;
        }
    }
}

class Program
{
    static void Main()
    {
        using (MyResource res = new MyResource())
        {
            // Use the resource
        } // Dispose() is called automatically here

        Console.WriteLine("End of Main");
    }
}

