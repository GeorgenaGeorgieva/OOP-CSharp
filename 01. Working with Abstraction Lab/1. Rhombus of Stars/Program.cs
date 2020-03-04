namespace RhombusOfStars
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int figureSize = int.Parse(Console.ReadLine());

            for (int row = 1; row <= figureSize; row++)
            {
                PrintRow(figureSize, row);
            }

            for (int row = figureSize - 1; row >= 1; row--)
            {
                PrintRow(figureSize, row);
            }
        }

        private static void PrintRow(int figureSize, int row)
        {
            for (int col = 0; col < figureSize - row; col++)
            {
                Console.Write(" ");
            }

            Console.Write("*");

            for (int col = 1; col < row; col++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }
    }
}
