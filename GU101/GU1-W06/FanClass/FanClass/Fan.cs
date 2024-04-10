namespace FanClass
{
    public class Fan
    {
        private const int SLOW = 1;
        private const int MEDIUM = 2;
        private const int FAST = 3;

        private int speed;
        private bool on;
        private double radius;
        private string color;

        public Fan()
        {
            speed = SLOW;
            on = false;
            radius = 5;
            color = "blue";
        }

        public Fan(int speed, bool on, double radius, string color)
        {
            this.speed = speed;
            this.on = on;
            this.radius = radius;
            this.color = color;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            if (on)
            {
                return $"Speed: {speed}, Color: {color}, Radius: {radius}, Fan is on";
            }
            else
            {
                return $"Color: {color}, Radius: {radius}, Fan is off";
            }
        }
    }
}
