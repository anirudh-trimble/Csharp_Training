using System;

class Program
{
    static void Main()
    {
        try
        {
            CauseException();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught in Main:");
            Console.WriteLine(ex.StackTrace);
        }
    }

    static void CauseException()
    {
        try
        {
            int x = 0;
            int y = 10 / x; // Divide by zero
        }
        catch (Exception ex)
        {
            // throw;      // preserves original stack trace
            throw ex;     // resets stack trace to this line
        }
    }
}
