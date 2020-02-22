namespace PointInRectangle
{
    using System;
    using System.Linq;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int topLeftX = coordinates[0];
            int topLeftY = coordinates[1];
            int bottomRightX = coordinates[2];
            int bottomRightY = coordinates[3];

            Point topLeft = new Point(topLeftX, topLeftY);
            Point bottomRight = new Point(bottomRightX, bottomRightY);

            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                int[] currentPointCoordinates = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                int x = currentPointCoordinates[0];
                int y = currentPointCoordinates[1];

                Point currentPoint = new Point(x, y);

                Console.WriteLine(rectangle.Contains(currentPoint)); 
            }
        }
    }
}
