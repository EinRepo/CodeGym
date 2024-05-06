namespace IResizable
{
    public class Square : Shape, IResizeable
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public void Resize(double percent)
        {
            side *= percent / 100.0;
        }
    }
}
 