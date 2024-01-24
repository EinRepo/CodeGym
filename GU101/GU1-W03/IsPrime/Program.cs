using System;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 2)
                Console.WriteLine(number + " is not a prime");
            else
            {
                int i = 2;
                bool flag = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        flag = false;
                        break;
                    }
                    i++;
                }
                if (flag)
                    Console.WriteLine(number + " is a prime");
                else
                    Console.WriteLine(number + " is not a prime");
            }
        }
    }
}