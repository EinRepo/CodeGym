using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();

            Console.WriteLine(square);

            square = new Square(2.3);

            Console.WriteLine(square);

            square = new Square(5.8, "yellow", true);

            Console.WriteLine(square);
            Console.ReadKey();
        }
    }
}
