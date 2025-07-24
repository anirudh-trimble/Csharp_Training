using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 10; i++)
        {
            if (i == 3)
            {
                Console.WriteLine("Skipping number 3 using continue");
                continue;  // Skip this iteration
            }

            if (i == 5)
            {
                Console.WriteLine("Stopping loop at 5 using break");
                break;  // Exit the loop
            }

            Console.WriteLine("Number: " + i);
        }

        // The below code basically loops until count is 5, skipping printing 3
        int count = 0;

    start:

        if (count == 3)
        {
            Console.WriteLine("Skipping count 3 using goto");
            count++;
            goto start;  // Skip printing 3
        }

        Console.WriteLine("Count: " + count);

        if (count < 5)
        {
            count++;
            goto start;  // Loop until count reaches 5
        }

        Console.WriteLine("Loop ended.");
    }
}
