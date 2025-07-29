using System;

namespace ArraysDemo
{
    class ArraysExample
    {
        static void Main(string[] args)
        {
            // SINGLE-DIMENSIONAL ARRAY
            int[] numbers = new int[5]; // Array of size 5

            // Assigning values
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            Console.WriteLine("Single-Dimensional Array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }

            Console.WriteLine();

            // MULTIDIMENSIONAL ARRAY (2D)
            int[,] matrix = new int[2, 3] // 2 rows, 3 columns
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            Console.WriteLine("Multidimensional (2D) Array:");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine(); // New line after each row
            }

        }
    }
}
