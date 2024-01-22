
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================");
            Console.WriteLine("|                    |");
            Console.WriteLine("|     CALCULATOR     |");
            Console.WriteLine("|                    |");
            Console.WriteLine("======================");

            double num1;
            while(true)
            {
                if(double.TryParse(Console.ReadLine(),out num1))
                {

                }
                Console.WriteLine("Input first number");
            };
            


            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input operator ( + - * / )");
            string ope = Console.ReadLine();
            Console.WriteLine("Input second number");
            double num2 = double.Parse(Console.ReadLine());
            double result;

            switch (ope){
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2; 
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    
                    return;

            }

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
            

        }
    }
}
