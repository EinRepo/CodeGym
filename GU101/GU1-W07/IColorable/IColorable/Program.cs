using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IColorable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Shape Test
            Shape shape1 = new Shape();
            Console.WriteLine(shape1);

            shape1 = new Shape("red", false);
            Console.WriteLine(shape1);

            // Circle Test
            Circle circle1 = new Circle();
            Console.WriteLine(circle1);

            circle1 = new Circle(3.5);
            Console.WriteLine(circle1);

            circle1 = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle1);

            // Square Test
            Square square1 = new Square();
            Console.WriteLine(square1);

            square1 = new Square(2.3);
            Console.WriteLine(square1);

            

            Console.WriteLine();

            // Create an array of shapes
            Shape[] shapes = new Shape[]
            {
                new Circle(3),
                new Rectangle(3, 4),
                new Square(5)
            };

            // Iterate over the array
            foreach (Shape shape in shapes)
            {
                // Display the area of the shape
                if (shape is Circle circle)
                {
                    Console.WriteLine($"Circle Area: {circle.getArea()}");
                }
                else if (shape is Rectangle rectangle)
                {
                    Console.WriteLine($"Rectangle Area: {rectangle.getArea()}");
                }
                else if (shape is Square square)
                {
                    Console.WriteLine($"Square Area: {square.getArea()}");
                }

                // Check if the shape is IColorable
                if (shape is IColorable colorable)
                {
                    // Call the HowToColor method
                    Console.WriteLine(colorable.HowToColor());
                }

                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
