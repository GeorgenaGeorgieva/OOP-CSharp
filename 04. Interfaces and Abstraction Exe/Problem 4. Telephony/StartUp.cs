namespace Telephony
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var URLs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Smartphone phone = new Smartphone();

            Console.WriteLine(phone.Call(phoneNumbers));
            Console.WriteLine(phone.Browse(URLs)); 
        }
    }
}
