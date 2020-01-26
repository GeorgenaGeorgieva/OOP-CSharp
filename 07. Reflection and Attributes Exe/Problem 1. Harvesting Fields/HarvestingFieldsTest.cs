namespace ProblemHarvestingFields
{
    using ProblemHarvestingFields.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string inputCommand = Console.ReadLine().ToLower();
            while (inputCommand != "harvest")
            {
                Type classType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == nameof(HarvestingFields));

                if (classType is null)
                {
                    throw new ArgumentException("Invalid class type!");
                }

                ICommand command = new Command(classType, inputCommand);
                Console.WriteLine(command.CommandImplemantation());

                inputCommand = Console.ReadLine().ToLower();
            }
        }
    }
}
