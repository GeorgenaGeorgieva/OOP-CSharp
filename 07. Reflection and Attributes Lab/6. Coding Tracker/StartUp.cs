using System;

namespace CodingTracker
{
    [Author("Ventsi")]
    public class StartUp
    {
        [Author("Gosho")]
        public static void Main(string[] args)
        {
            var tracker = new Tracker();
            var result = tracker.PrintMethodsByAuthor();
            Console.WriteLine(result);
        }
    }
}
