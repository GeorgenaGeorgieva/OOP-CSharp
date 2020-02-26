namespace PersonsInfo
{
    using System;
     
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var team = new Team("The Lions");

            for (int i = 0; i < lines; i++)
            {
                var personInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var firstName = personInformation[0];
                var lastName = personInformation[1];
                var age = int.Parse(personInformation[2]);
                var salary = decimal.Parse(personInformation[3]);

                var person = new Person(firstName, lastName, age, salary);
                team.AddPlayer(person);
            }

            Console.WriteLine(team);
        }
    }
}
