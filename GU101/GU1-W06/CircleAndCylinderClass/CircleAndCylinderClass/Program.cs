using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndCylinderClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Triển khai lớp Circle
            Circle circle1 = new Circle(5.0, "Red");
            Console.WriteLine(circle1.ToString());

            // Cập nhật thông tin về hình tròn
            circle1.SetRadius(10.0);
            circle1.SetColor("Blue");
            Console.WriteLine(circle1.ToString());

            // Kiểm thử phương thức GetArea()
            double area = circle1.GetArea();
            Console.WriteLine($"Area of the circle: {area}");

            // Triển khai lớp Cylinder
            Cylinder cylinder1 = new Cylinder(5.0, "Red", 10.0);
            Console.WriteLine(cylinder1.ToString());

            // Cập nhật thông tin về hình trụng
            cylinder1.SetRadius(10.0);
            cylinder1.SetColor("Blue");
            cylinder1.SetHeight(15.0);
            Console.WriteLine(cylinder1.ToString());

            // Kiểm thử phương thức GetVolume()
            double volume = cylinder1.GetVolume();
            Console.WriteLine($"Volume of the cylinder: {volume}");

            Console.ReadKey();

            

        }
    }
}
