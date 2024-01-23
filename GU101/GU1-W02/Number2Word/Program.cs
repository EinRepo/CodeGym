using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter a positive integer, up to 3 digits:");
            bool tryParseInt = int.TryParse(Console.ReadLine(), out number);
            if (number < 0 || number > 999 || tryParseInt == false)
                Console.WriteLine("Out of ability");
            else
            {
                string result = ConvertToWords(number);
                Console.WriteLine("Written Number: " + result);
            }


        }

        static string ConvertToWords(int number)
        {
            if (number < 10)
                return ConvertOnes(number);

            if (number < 20)
                return ConvertTeens(number);

            if (number < 100)
            {
                int ones = number % 10;
                int tens = number / 10;
                return ConvertTens(tens) + " " + ConvertOnes(ones);
            }

            if (number < 1000)
            {
                int ones = number % 10;
                int tens = (number / 10) % 10;
                int hundreds = number / 100;
                string result = ConvertOnes(hundreds) + " hundred";
                if (number % 100 != 0)
                    result += " and " + ConvertToWords(number % 100);
                return result;
            }
            return "";
        }
        static string ConvertOnes(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "";
            }
        }

        static string ConvertTeens(int number)
        {
            switch (number)
            {
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                default:
                    return "";
            }
        }

        static string ConvertTens(int number)
        {
            switch (number)
            {
                case 2:
                    return "twenty";
                case 3:
                    return "thirty";
                case 4:
                    return "forty";
                case 5:
                    return "fifty";
                case 6:
                    return "sixty";
                case 7:
                    return "seventy";
                case 8:
                    return "eighty";
                case 9:
                    return "ninety";
                default:
                    return "";
            }
        }
    }
}

