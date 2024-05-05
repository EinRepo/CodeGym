using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComparableCircle[] circles = new ComparableCircle[3];
            circles[0] = new ComparableCircle(3.6);
            circles[1] = new ComparableCircle();
            circles[2] = new ComparableCircle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (ComparableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (ComparableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Console.ReadKey();
        }
    }
}
