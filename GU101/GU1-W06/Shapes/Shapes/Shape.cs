using System;

namespace Shapes
{
    public class Shape

    {

        private String color = "green";

        private bool filled = true;

        public Shape()

        {

        }

        public Shape(String color, bool filled)

        {

            this.color = color;

            this.filled = filled;

        }

        public String GetColor()

        {

            return color;

        }

        public void SetColor(String color)

        {

            this.color = color;

        }

        public bool IsFilled()

        {

            return filled;

        }

        public void SetFilled(bool filled)

        {

            this.filled = filled;

        }

        public override String ToString()

        {

            return "A Shape with color of "

                    +GetColor()

                    + " and "

                    +(IsFilled() ? "filled" : "not filled");

        }

    }
}
