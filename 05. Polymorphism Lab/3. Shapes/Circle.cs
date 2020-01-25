namespace Shapes
{
    using Interfaces;
    using System;

    public class Circle : Shape, ICircle
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid radius!");
                }

                this.radius = value;
            }
        }

        public override double CalculateArea()
        {
            double area = Math.PI * Math.Pow(this.Radius, 2);
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
