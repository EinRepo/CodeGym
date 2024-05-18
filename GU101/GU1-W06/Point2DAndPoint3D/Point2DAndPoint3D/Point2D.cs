namespace Point2DAndPoint3D
{
    public class Point2D
    {
        protected float x = 0.0f;
        protected float y = 0.0f;

        // Constructors
        public Point2D()
        {
        }

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        // Getters
        public float getX()
        {
            return x;
        }

        public float getY()
        {
            return y;
        }

        // Setters
        public void setX(float x)
        {
            this.x = x;
        }

        public void setY(float y)
        {
            this.y = y;
        }

        

    }
}
