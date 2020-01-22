namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var personInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var firstName = personInformation[0];
                var lastName = personInformation[1];
                var age = int.Parse(personInformation[2]);
                var salary = decimal.Parse(personInformation[3]);

                var person = new Person(firstName, lastName, age, salary);
                people.Add(person);
            }

            var bonus = decimal.Parse(Console.ReadLine());

            people.ForEach(p => p.IncreaseSalary(bonus));
            people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
