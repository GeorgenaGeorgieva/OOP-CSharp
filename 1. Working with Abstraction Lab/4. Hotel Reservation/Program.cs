namespace HotelReservation
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputLine = Console.ReadLine()
                .Split();
            var priceCalculator = new PriceCalculator(inputLine);

            Console.WriteLine(priceCalculator.CalculatePrice().ToString("F2"));
        }
    }
}
