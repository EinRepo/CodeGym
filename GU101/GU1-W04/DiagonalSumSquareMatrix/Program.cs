using System;

namespace DiagonalSumSquareMatrix
{
    class Program
    {
        static void Main()
        {
            double[,] numbers;
            int sideLength;
            Console.Write("Enter the the length of the square-matrix's sides: ");
            sideLength = int.Parse(Console.ReadLine()); Console.WriteLine();
            numbers = new double[sideLength, sideLength];

            //insert values into the array
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write("Enter value for position row {0} column {1}: ", i + 1, j + 1);
                    numbers[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            //Sum of diagonal
            double sum = 0;

            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    if (i == j)
                    {
                        sum += numbers[i, j];
                    }
                }
            }

            //Print out the array and the sum
            Console.WriteLine("The array: \n");
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0}\t", numbers[i, j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("{0}\t", numbers[i, j]);
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sum of the diagonal (connecting top-left and bottom-right): " + sum);
            Console.ResetColor();
            Console.WriteLine();

        }
    }
}
