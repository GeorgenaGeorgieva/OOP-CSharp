namespace Shapes
{
    using Interfaces;

    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    

        public virtual string Draw()
        {
            return "Drawing ";
        }
    }
}
