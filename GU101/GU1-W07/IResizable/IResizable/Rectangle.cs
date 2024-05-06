namespace IResizable
{
    public class Rectangle : Shape, IResizeable
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }

        public void Resize(double percent)
        {
            width *= percent / 100.0;
            height *= percent / 100.0;
        }
    }
}
 