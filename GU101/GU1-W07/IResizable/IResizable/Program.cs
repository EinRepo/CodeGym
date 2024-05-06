using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IResizable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một mảng các hình
            Shape[] shapes = new Shape[]
            {
            new Circle(5),
            new Rectangle(4, 6),
            new Square(3)
            };

            Circle circle = new Circle(5);
            circle.Resize(10);
            

            // Tăng kích thước ngẫu nhiên và hiển thị diện tích trước và sau khi tăng kích thước
            Random random = new Random();
            foreach (Shape shape in shapes)
            {
                double initialArea = shape.Area();
                Console.WriteLine("Initial Area: " + initialArea);

                double resizePercent = random.Next(1, 101);
                Console.WriteLine("Resize Percent: " + resizePercent + "%");

                IResizeable resizableShape = shape as IResizeable;
                resizableShape.Resize(resizePercent);

                double resizedArea = shape.Area();
                Console.WriteLine("Area after resize: " + resizedArea);
                Console.WriteLine();
            }

            Console.ReadKey();
            

        }
    }
}
