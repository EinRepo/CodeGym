using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_CaulenhDieuKien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai hoc 2 - Cau lenh dieu kien if");

            //bool c = false;
            //bool d = true;
            //int ab = 10;
            //int a = 10;
            //int b = 20;
            //if (a < b)     //so sanh bang 
            //{
            //    console.writeline("a < b");
            //}
            //else
            //{
            //    console.writeline("a > b");
            //}
            //console.readkey();



            ////BT kiem tra so a co chia het cho so b
            //Console.WriteLine("Nhap so a");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap so b");
            //int b = int.Parse(Console.ReadLine());

            //if (b != 0 && a % b == 0)
            //{
            //    Console.WriteLine("a chia het cho b");
            //}
            //else if (b != 0)
            //{
            //    int phanDu = a % b;
            //    Console.WriteLine("a k chia het cho b va du: " + phanDu);
            //}


            //Tim x, cho ax + b = c
            Console.WriteLine("Tim x cho phuong trinh ax + b = c");
            Console.WriteLine("Nhap so a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so c");
            int c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == c)
                {
                    Console.WriteLine("Infinite amount of xs");
                }
                else
                {
                    Console.WriteLine("X cannot be found");
                }
            }
            else
            {
                double x = (double)(c - b) / a;
                Console.WriteLine("Value of X: " + x);
            }



            Console.ReadKey();
        }
    }
}
