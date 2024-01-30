using System;

namespace Array2DFindMax
{
    class Program
    {
        static void Main()
        {
            double[,] numbers;
            int rows; int columns;
            Console.WriteLine("How many rows?: ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns?: ");
            columns = int.Parse(Console.ReadLine());
            numbers = new double[rows, columns];

            //insert values into the array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter value for position row {0} column {1}: ", i + 1, j + 1);
                    numbers[i, j] = double.Parse(Console.ReadLine());
                }
            }

            //Find max in array
            double max = 0;
            int maxRowPos = 0;
            int maxColumnPos = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (max < numbers[i, j])
                    {
                        max = numbers[i, j];
                        maxRowPos = i + 1;
                        maxColumnPos = j + 1;
                    }
                }
            }

            //Print out the biggest num
            Console.WriteLine("The array: \n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0}\t", numbers[i, j]);
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("The biggest number is {0} at row {1} column {2}", max, maxRowPos, maxColumnPos);

        }
    }
}