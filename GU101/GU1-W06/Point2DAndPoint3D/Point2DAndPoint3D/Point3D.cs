namespace Point2DAndPoint3D
{
    public class Point3D : Point2D
    {
        private float z = 0.0f;

        // Constructors
        public Point3D() : base() { }

        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }

        // Getter
        public float GetZ()
        {
            return z;
        }

        // Setter
        public void SetZ(float z)
        {
            this.z = z;
        }

        // Set x, y, and z
        public void SetXYZ(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Get x, y, and z as an array
        public float[] GetXYZ()
        {
            return new float[] { x, y, z };
        }

        // ToString method
        public override string ToString()
        {
            return $"({x},{y},{z})";
        }
    }


}