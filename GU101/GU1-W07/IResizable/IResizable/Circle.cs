using System;

namespace IResizable
{
    public class Circle : Shape, IResizeable
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public void Resize(double percent)
        {
            radius *= percent / 100.0;
        }
    }
}
