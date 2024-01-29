using System;

namespace ArrayAddElement
{
    class Program
    {
        static void Main()
        {
            int[] array = { 3, 4, 5, 6, 7, 0, 0, 0, 0, 0 }; //10 so

            Console.Write("Enter X: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Index position: ");
            int index = int.Parse(Console.ReadLine());

            if (index <= 1 && index >= array.Length - 1)
            {
                Console.WriteLine("Element cannot be added.");
            }
            else
            {
                for (int i = array.Length - 1; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = X;

                // Bước 6: In ra mảng
                Console.WriteLine("Mảng sau khi chèn:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}