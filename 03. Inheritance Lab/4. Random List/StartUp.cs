namespace CustomRandomList
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var randomList = new RandomList();

            randomList.Add("Ivan");
            randomList.Add("Petar");
            randomList.Add("Stafan");

            Console.WriteLine(randomList.RandomString());
        }
    }
}
