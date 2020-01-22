namespace Cars
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                ICar seat = new Seat("Leon", "Grey");
                ICar tesla = new Tesla("Model 3", "Red", 2);

                Console.WriteLine(seat.ToString());
                Console.WriteLine(tesla.ToString());
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
