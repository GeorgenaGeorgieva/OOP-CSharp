namespace ClassBoxData
{
    using System;
     
    public class Program
    {
        public static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);

                box.GetSurfaceArea();
                box.GetLateralSurfaceArea();
                box.GetVolume();

                Console.WriteLine(box);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
