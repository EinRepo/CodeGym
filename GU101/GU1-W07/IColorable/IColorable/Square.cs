namespace IColorable
{
    public class Square : Shape, IColorable
    {
        private double side;
        public Square()
        {
        }

          public Square(double side)
        {
            this.side = side;
        }
        public double getSide()
        {
            return side;
        }
        public double getArea()
        {
            return side * side;
        }

        public string HowToColor()
        {
            return "Color all 4 equal sides";
        }

        public override string ToString()
        {
            return "A Square with side="
                    + getSide()
                    + ", which is a subclass of "
                    + base.ToString();
        }
    }
}
