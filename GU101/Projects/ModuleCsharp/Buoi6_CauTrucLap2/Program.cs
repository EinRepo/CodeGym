using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_CauTrucLap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bai truoc
            //int i = 0;
            // // continue
            //for (i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("So hien tai: " + i);
            //}

            // // break : thoát khỏi vòng lặp
            //for (i = 0; i < 10; i++)
            //{
            //    if (i > 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("So hien tai: " + i);
            //}

            //Console.WriteLine("Vong lap dung lai tai: " + i);

            //i = 1;
            //while (i < 10) 
            //{
            //    Console.WriteLine("So hien tai: " + i);
            //    i = i * 2;
            //}


            // Console.WriteLine("Vong lap dung lai tai: " + i);
            #endregion
            #region B1
            // In ra hinh chu nhat su dung while

            /*
            - Lặp CR lần
	            - Vẽ 1 dòng: 
		            -lặp CD lần in ra *
	            - Xuống dòng 
            */
            //int chieuDai = 0;
            //int chieuRong = 0;

            //Console.Write("Chieu dai: ");
            //chieuDai = int.Parse(Console.ReadLine());

            //Console.Write("Chieu rong: ");
            //chieuRong = int.Parse(Console.ReadLine());

            //int bienLapCR = 0;
            //// for (khởi tạo; điều kiện; bước nhảy)
            //while (bienLapCR < chieuRong)
            //{
            //    // Vẽ ra 1 dòng  *****
            //    int bienLapCD = 0;
            //    while (bienLapCD < chieuDai)
            //    {
            //        Console.Write("*");
            //        bienLapCD++;
            //    }
            //    Console.WriteLine();
            //    bienLapCR++;
            //}
            #endregion
            #region ve hinh
            //int choice = -1;
            //while (true)
            //{
            //    // Menu
            //    Console.WriteLine("Menu");
            //    Console.WriteLine("1. Draw the triangle");
            //    Console.WriteLine("2. Draw the square");
            //    Console.WriteLine("3. Draw the rectangle");
            //    Console.WriteLine("0. Exit");
            //    Console.Write("Enter your choice: ");
            //    choice = int.Parse(Console.ReadLine());

            //    if (choice == 0)
            //    {
            //        Console.WriteLine("Good bye!!");
            //        break;
            //    }
            //    else if (choice == 1)
            //    {
            //        Console.WriteLine("Draw the triangle");
            //        Console.WriteLine("******");
            //        Console.WriteLine("*****");
            //        Console.WriteLine("****");
            //        Console.WriteLine("***");
            //        Console.WriteLine("**");
            //        Console.WriteLine("*");
            //    } 
            //    else if (choice == 2)
            //    {
            //        Console.WriteLine("Draw the square");
            //        Console.WriteLine("* * * * * *");
            //        Console.WriteLine("* * * * * *");
            //        Console.WriteLine("* * * * * *");
            //        Console.WriteLine("* * * * * *");
            //        Console.WriteLine("* * * * * *");
            //        Console.WriteLine("* * * * * *");
            //    }
            //    else if (choice == 3)
            //    {
            //        Console.WriteLine("Draw the rectangle");
            //        Console.WriteLine("* * * * * *");
            //        Console.WriteLine("* * * * * *");
            //        Console.WriteLine("* * * * * *");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please input again!");
            //    }

            //    Console.ReadKey();
            //    Console.Clear();
            //}
            #endregion
            // SNT: là số lớn hơn 1 và chỉ có ước là 1 và chính nó => chỉ có 2 ước
            // => Để ktra đc 1 số có là SNT hay không
            // => kiểm tra số các số ước của nó == 2 => SNT
            // => ko phải
            // 6 : 1, 2, 3, 6
            #region B2
            //int n = int.Parse(Console.ReadLine());
            //if (n <= 1)
            //{
            //    Console.WriteLine(n + " khong phai nguyen to");
            //}
            //else
            //{
            //    int bienDemUoc = 0;
            //    // 1 2 3 4 5 6 7 .. n
            //    for (int i = 1; i <= n; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            bienDemUoc++;
            //        }
            //    }

            //    if (bienDemUoc == 2)
            //    {
            //        Console.WriteLine(n + " la nguyen to");
            //    }
            //    else
            //    {
            //        Console.WriteLine(n + " khong la nguyen to");
            //    }
            //}

            #endregion
            #region B3
            int choice = -1;
            while (true)
            {
                // Menu
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    Console.WriteLine("Good bye!!");
                    break;
                }
                else if (choice == 1)
                {
                    Console.WriteLine("Draw the triangle");
                    Console.Write("Nhap canh cua hinh tam giac: ");
                    int canh;
                    canh = int.Parse(Console.ReadLine());

                    int doDaiCanh = canh;
                    for (int i = 0; i < canh; i++)
                    {
                        for (int j = 0; j < doDaiCanh; j++)
                        {
                            Console.Write("*");
                        }

                        doDaiCanh = doDaiCanh - 1;
                        Console.WriteLine();
                    }

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Draw the square");
                    int canh;
                    Console.Write("Nhap canh cua hinh vuong: ");
                    canh = int.Parse(Console.ReadLine());

                    int chieuDai = canh;
                    int chieuRong = canh;

                    int bienLapCR = 0;
                    // for (khởi tạo; điều kiện; bước nhảy)
                    while (bienLapCR < chieuRong)
                    {
                        // Vẽ ra 1 dòng  *****
                        int bienLapCD = 0;
                        while (bienLapCD < chieuDai)
                        {
                            Console.Write("*");
                            bienLapCD++;
                        }
                        Console.WriteLine();
                        bienLapCR++;
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Draw the rectangle");

                    int chieuDai = 0;
                    int chieuRong = 0;

                    Console.Write("Nhap chieu dai cua hinh vuong: ");
                    chieuDai = int.Parse(Console.ReadLine());

                    Console.Write("Nhap chieu rong cua hinh vuong: ");
                    chieuRong = int.Parse(Console.ReadLine());


                    int bienLapCR = 0;
                    // for (khởi tạo; điều kiện; bước nhảy)
                    while (bienLapCR < chieuRong)
                    {
                        // Vẽ ra 1 dòng  *****
                        int bienLapCD = 0;
                        while (bienLapCD < chieuDai)
                        {
                            Console.Write("*");
                            bienLapCD++;
                        }
                        Console.WriteLine();
                        bienLapCR++;
                    }
                }
                else
                {
                    Console.WriteLine("Please input again!");
                }

                Console.ReadKey();
                Console.Clear();
            }
            #endregion
            // Test Commit co su thay doi
            Console.ReadKey();
        }
    }
}