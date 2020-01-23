namespace Ferrari
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                string driver = Console.ReadLine();
                ICar driveFerrari = new Ferrari(driver);

                Console.WriteLine(driveFerrari);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
