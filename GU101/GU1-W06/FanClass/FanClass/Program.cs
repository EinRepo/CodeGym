using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan(3, true, 10, "yellow");
            Fan fan2 = new Fan(2, false, 5, "blue");

            Console.WriteLine("Fan 1 - " + fan1.ToString());
            Console.WriteLine("Fan 2 - " + fan2.ToString());

            Console.ReadKey();  
        }
    }
}
