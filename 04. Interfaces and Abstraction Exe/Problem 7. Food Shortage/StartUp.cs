namespace FoodShortage
{
    using Objects;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> buyers = new List<Person>();
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var peopleInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = peopleInformation[0];
                var age = int.Parse(peopleInformation[1]);
                try
                {
                    if (peopleInformation.Length == 4)
                    {
                        var id = peopleInformation[2];
                        var birthdate = peopleInformation[3];

                        var citizen = new Citizen(name, age, id, birthdate);
                        buyers.Add(citizen);
                    }
                    else if (peopleInformation.Length == 3)
                    {
                        var group = peopleInformation[2];

                        var rebel = new Rebel(name, age, group);
                        buyers.Add(rebel);
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            var command = Console.ReadLine();

            while (command != "End")
            {
                var name = command.TrimEnd();
                var currentbuyer = buyers.SingleOrDefault(x => x.Name == name);

                if (currentbuyer != null)
                {
                    currentbuyer.BuyFood();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
