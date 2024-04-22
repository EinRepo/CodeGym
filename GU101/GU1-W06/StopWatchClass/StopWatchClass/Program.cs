using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateRandomNumbers(100000);

            StopWatch stopwatch = new StopWatch();
            stopwatch.Start();

            Console.WriteLine("CALCULATING...");

            SelectionSort(numbers);

            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.GetElapsedTime();
            Console.WriteLine($"Elapsed time: {elapsedTime.TotalMilliseconds} milliseconds");
            Console.ReadKey();

        }

        public static void SelectionSort(int[] arr)
        {
            // Thuật toán sắp xếp chọn (Selection Sort)
            int arrayLength = arr.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        public static int[] GenerateRandomNumbers(int count)
        {
            Random random = new Random();
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(1000); //generate random number range 0-999
            }
            return numbers;
        }
    }

}
