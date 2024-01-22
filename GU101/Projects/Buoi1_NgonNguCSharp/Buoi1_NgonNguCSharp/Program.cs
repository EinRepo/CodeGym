using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_NgonNguCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Gioi thieu kieu du liệu
            //// Kieu_du_lieu <tenbien>

            //// string: lưu giá trị cho một chuỗi
            //// int: lưu giá trị cho một số nguyên (1,2,3,4,5,6,78,90)
            //// float: lưu giá trị cho một số thực (1.2, 1.5, 2.7, 1.0)

            //// => float > int

            //string myName;
            //int myInteger;
            //float myFloat;

            //myFloat = 1.9f;
            ////Console.WriteLine("Variable of myFloat is: " + myFloat);

            //// myInteger = 900;
            ////Console.WriteLine("Variable of myInteger is: " + myInteger);


            //myInteger = (int)8.7f;
            ////Console.WriteLine("After cast myInteger is: " + myInteger);

            //myName = "" + myFloat;
            //Console.WriteLine("After cast myName is: " + myName);




            //myName = "Test string variable";
            //// Đây là câu lệnh ghép chuỗi và số và chuỗi lại thành chuỗi mới
            ////Console.WriteLine(myName);

            //myName = "Code Gym Online";
            ////Console.WriteLine(myName);

            //myName = "Change Variable Third Time";
            ////Console.WriteLine(myName);
            #endregion

            // Gioi thieu toan tu
            int myFirstNumber = 10;
            int mySecondNumber = 20;

            int mySum = myFirstNumber + mySecondNumber;
            int mySub = myFirstNumber - mySecondNumber;
            int myMultiple = myFirstNumber * mySecondNumber;
            float myDivide = myFirstNumber / (float)mySecondNumber; // 0.5 => 0

            int myMod = myFirstNumber % mySecondNumber;

            Console.WriteLine("My Sum is: " + mySum);
            Console.WriteLine("My Sub is: " + mySub);
            Console.WriteLine("My Multiple is: " + myMultiple);
            Console.WriteLine("My Divide is: " + myDivide);
            Console.WriteLine("My Mod is: " + myMod);

            DateTime localDate = DateTime.Now;
            Console.WriteLine("CurrentTime: " + localDate);

            Console.ReadKey();
        }
    }
}