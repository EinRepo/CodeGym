using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesAppeared
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bước 1: Khai báo và gán giá trị cho chuỗi
            string str = "Beef jerky beefy jerk jerked beefy berked jeefy";
            Console.WriteLine(str);

            // Bước 2: Khai báo và nhập giá trị cho ký tự
            Console.Write("Character for counting: ");
            char character = Console.ReadLine()[0];
            Console.WriteLine();

            // Gọi phương thức TimesAppeared để đếm số lần xuất hiện của ký tự trong chuỗi
            int count = TimesAppeared(str, character);

            // In ra giá trị biến đếm 
            Console.WriteLine("Amounts of time character '" + character + "' appeared in string is: " + count);
            Console.ReadKey();
        }

        // Phương thức TimesAppeared để đếm số lần xuất hiện của ký tự trong chuỗi
        static int TimesAppeared(string str, char character)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == character)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
