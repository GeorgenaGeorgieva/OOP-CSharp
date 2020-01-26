namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type classType = Assembly
                    .GetCallingAssembly()
                    .GetTypes()
                    .FirstOrDefault(x => x.Name is nameof(BlackBoxInteger));

            BlackBoxInteger instance = (BlackBoxInteger)Activator
                .CreateInstance(classType, true);

            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                string[] inputArguments = inputLine
                    .Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

                string methodName = inputArguments[0];
                int number = int.Parse(inputArguments[1]);

                classType.GetMethod(methodName, 
                    BindingFlags.Instance | 
                    BindingFlags.NonPublic | 
                    BindingFlags.Public)
                    .Invoke(instance, new object[] { number });

                int currentResult = (int)classType.GetField("innerValue",
                    BindingFlags.Instance |
                    BindingFlags.NonPublic |
                    BindingFlags.Public)
                    .GetValue(instance);

                Console.WriteLine(currentResult);

                inputLine = Console.ReadLine();
            }
        }
    }
}
