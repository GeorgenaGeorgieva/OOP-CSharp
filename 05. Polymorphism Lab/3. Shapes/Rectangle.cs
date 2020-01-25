namespace Shapes
{
    using Interfaces;
    using System;

    public class Rectangle : Shape, IRectangle
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid height!");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid width!");
                }

                this.width = value;
            }
        }

        public override double CalculateArea()
        {
            double area = this.Width * this.Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (2 * this.Height) + (2 * this.Width);
            return perimeter;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
