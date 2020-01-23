namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var participants = new List<IIdentifiable>();
            var command = Console.ReadLine();

            while (command != "End")
            {
                var passing = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    if (passing.Length == 2)
                    {
                        var model = passing[0];
                        var id = passing[1];

                        var robot = new Robot(model, id);
                        participants.Add(robot);
                    }
                    else if (passing.Length == 3)
                    {
                        var name = passing[0];
                        var age = int.Parse(passing[1]);
                        var id = passing[2];

                        var citizen = new Citizen(name, age, id);
                        participants.Add(citizen);
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                command = Console.ReadLine();
            }

            var endFakeId = Console.ReadLine();

            participants
                .Select(x => x.Id)
                .Where(x => x.EndsWith(endFakeId))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
