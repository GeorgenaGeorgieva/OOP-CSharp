namespace BirthdayCelebrations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Interfaces;
    using Objects;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var creatures = new List<IAlive>();

            var command = Console.ReadLine();
            while (command != "End")
            {
                var information = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = information[1];
                try
                {
                    if (information[0] == "Citizen")
                    {
                        var age = int.Parse(information[2]);
                        var id = information[3];
                        var birthdate = information[4];

                        var citizen = new Citizen(name, age, id, birthdate);
                        creatures.Add(citizen);
                    }
                    else if (information[0] == "Pet")
                    {
                        var birthdate = information[2];

                        var pet = new Pet(name, birthdate);
                        creatures.Add(pet);
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
      
                command = Console.ReadLine();
            }

            var endsWithYear = Console.ReadLine();

            creatures
                .Select(x => x.Birthdate)
                .Where(x => x.EndsWith(endsWithYear))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
