namespace CustomStack
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var customStack = new StackOfStrings();

            Console.WriteLine(customStack.IsEmpty());

            var rangeElements = new Stack<string>();
            rangeElements.Push("Pesho");
            rangeElements.Push("Gosho");
            rangeElements.Push("Ivan");

            customStack.AddRange(rangeElements);

            Console.WriteLine(customStack.IsEmpty());

            foreach (var element in customStack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
