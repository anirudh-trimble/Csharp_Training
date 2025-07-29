using System;

namespace CustomExceptionDemo
{
    // Step 1: Define your custom exception
    public class AgeValidationException : Exception
    {
        public AgeValidationException() { }

        public AgeValidationException(string message) : base(message) { }
    }

    // Step 2: Use it in a method
    class User
    {
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new AgeValidationException("Age must be 18 or older.");
            }
            Console.WriteLine("Age is valid.");
        }
    }

    // Step 3: Catch and handle it
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            try
            {
                user.ValidateAge(15);
            }
            catch (AgeValidationException ex)
            {
                Console.WriteLine("Custom Exception Caught: " + ex.Message);
            }
        }
    }
}
