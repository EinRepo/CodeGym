using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_ThucHanhCauLenhDieuKien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bai_4
            //Console.Write("Moi ban nhap tuoi: ");
            //int tuoi = int.Parse(Console.ReadLine());

            //if (tuoi > 0 && tuoi <= 2)
            //{
            //    Console.WriteLine("Tre so sinh");
            //}
            //else if (tuoi > 2 && tuoi <= 10)
            //{
            //    Console.WriteLine("Nhi dong");
            //}
            //else if (tuoi > 10 && tuoi <= 17)
            //{
            //    Console.WriteLine("Vi thanh nien");
            //}
            //else if (tuoi > 17 && tuoi <= 39)
            //{
            //    Console.WriteLine("Thanh nien");
            //}
            //else if (tuoi > 39 && tuoi <= 50)
            //{
            //    Console.WriteLine("Trung nien");
            //}
            //else
            //{
            //    Console.WriteLine("Cao nien");
            //}

            #endregion

            #region Bai_3
            //int currentYear = 2024;

            //Console.Write("Nhập năm sản xuất của máy tính: ");
            //int manufacturingYear = int.Parse(Console.ReadLine());

            //int yearsDifference = currentYear - manufacturingYear;

            //if (yearsDifference >= 15)
            //{
            //    Console.WriteLine("Đề xuất: Thay thế");
            //}
            //else if (yearsDifference >= 10 && yearsDifference < 15)
            //{
            //    Console.WriteLine("Đề xuất: Bảo trì");
            //}
            //else
            //{
            //    Console.WriteLine("Không có đề xuất");
            //}

            #endregion

            #region Bai_1
            //Console.Write("Enter the salary: ");
            //double salary = double.Parse(Console.ReadLine());

            //Console.Write("Enter the hours worked in a month: ");
            //int hoursWorked = int.Parse(Console.ReadLine());

            //double bonus = 0.0;

            //if (hoursWorked >= 200)
            //{
            //    bonus = 0.2 * salary;
            //}
            //else if (hoursWorked >= 100 && hoursWorked < 200)
            //{
            //    bonus = 0.1 * salary;
            //}

            //double totalPayment = salary + bonus;

            //Console.WriteLine("Bonus: " + bonus);
            //Console.WriteLine("Total Payment: " + totalPayment);

            #endregion

            #region Bai_1_2

            Console.Write("Enter integer N: ");
            double n = double.Parse(Console.ReadLine());

            // Kiểm tra N có phải số nguyên không
            // Kiểm tra tính chẵn lẻ của N
            // Kiểm tra tính chẵn dương của N
            // Kiểm tra tính lẻ âm của N
            // Kiểm tra N có phải số chính phương không
            // Kiểm tra N có phải số đặc biệt không
            bool isInteger = false;
            bool isEven = false;
            bool isOdd = false;
            bool isPositiveEven = false;
            bool isNegativeOdd = false;
            bool isPerfectSquare = false;
            bool isSpecial = false;
            if (n == (int)n)
            {
                isInteger = true;
                isEven = (n % 2 == 0);
                isOdd = !isEven;
                isPositiveEven = (n > 0 && n % 2 == 0);
                isNegativeOdd = (n < 0 && n % 2 != 0);
                isPerfectSquare = (Math.Sqrt(n) % 1 == 0);
                if (n > 0 && n < 1000)
                {
                    int sumOfCubedDigits = 0;
                    int temp = (int)n;
                    while (temp != 0)
                    {
                        int digit = temp % 10;
                        sumOfCubedDigits += (int)Math.Pow(digit, 3);
                        temp /= 10;
                    }
                    isSpecial = (sumOfCubedDigits == n);
                }
            }

            
            
            

            Console.WriteLine("1. N is Integer: " + isInteger);
            Console.WriteLine("2. N is even: " + isEven);
            Console.WriteLine("   N is odd: " + isOdd);
            Console.WriteLine("3. N is Positive Even: " + isPositiveEven);
            Console.WriteLine("   N is Negative Odd: " + isNegativeOdd);
            Console.WriteLine("4. N is Perfect Square: " + isPerfectSquare);
            Console.WriteLine("5. N is Special (number is equal to the sums of its cubed digits): " + isSpecial);


            #endregion
            Console.ReadKey();
        }
    }
}
