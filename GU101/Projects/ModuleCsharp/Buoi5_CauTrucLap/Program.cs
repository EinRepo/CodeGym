using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5_CauTrucLap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bai_1
            //// Tính tổng từ 1 -> n và n nhập từ bàn phím
            //int n;
            //int sum = 0;
            //int i;

            //Console.Write("N=");
            //n = int.Parse(Console.ReadLine());

            //int soHienTai = 1;
            //for (i = 1; i <= n; i += 1)
            //{
            //    sum = sum + soHienTai;
            //    soHienTai = soHienTai + 1;
            //}

            //Console.WriteLine("Sum: " + sum);
            #endregion

            #region Bai_2
            ////In ra cac uoc cua n
            ////vd uoc cua 6 => 1 2 3 6   
            //Console.WriteLine("Tim uoc cua N");
            //Console.Write("Nhap N: ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= n; i++)
            //{
            //    if(n % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Bai_3
            //// Nhap n
            //// In ra bang cuu chuong theo dinh dang
            //// n = 3
            //// Bang cuu chuong cua 3
            //// 3 x 1 = 3
            //// 3 x 2 = 6
            //// ...
            //// 3 x 10 = 30

            //Console.Write("Nhap N: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bang cuu chuong cua " + n + "\n");
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(n + " * " + i + " = " + (n * i));
            //}

            #endregion

            #region Bai_4

            //Print rectangle
            Console.WriteLine("Please enter a height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a width ");
            int width = int.Parse(Console.ReadLine());
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
