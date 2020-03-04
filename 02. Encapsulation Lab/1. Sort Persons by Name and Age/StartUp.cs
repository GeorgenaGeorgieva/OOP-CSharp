namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>();
            
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var personInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var firstName = personInformation[0];
                var lastName = personInformation[1];
                var age = int.Parse(personInformation[2]);

                var person = new Person(firstName, lastName, age);
                people.Add(person);
            }

            people.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
