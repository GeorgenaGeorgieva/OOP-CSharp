namespace Shapes
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                Shape circle = new Circle(2.5);
                Shape rectangle = new Rectangle(6, 3);

                Console.WriteLine(circle.CalculateArea());
                Console.WriteLine(circle.CalculatePerimeter());
                Console.WriteLine(circle.Draw());

                Console.WriteLine(rectangle.CalculateArea());
                Console.WriteLine(rectangle.CalculatePerimeter());
                Console.WriteLine(rectangle.Draw());
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
