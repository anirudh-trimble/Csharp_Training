using System;

public class DataService
{
    public void LoadData()
    {
        try
        {
            // Simulate a low-level failure (e.g., network error)
            throw new InvalidOperationException("Unable to connect to the database.");
        }
        catch (InvalidOperationException ex)
        {
            // Wrap and rethrow with more context
            throw new ApplicationException("Failed to load user data in service layer.", ex);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataService service = new DataService();

        try
        {
            service.LoadData();
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine("Caught Exception: " + ex.Message);

            // Accessing the inner exception
            if (ex.InnerException != null)
            {
                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
            }
        }
    }
}
