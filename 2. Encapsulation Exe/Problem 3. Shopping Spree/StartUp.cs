namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInformation = Console.ReadLine()
                .Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < peopleInformation.Length; i += 2)
            {
                string name = peopleInformation[i];
                decimal money = decimal.Parse(peopleInformation[i + 1]);
                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }

            string[] productsInformation = Console.ReadLine()
                .Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < productsInformation.Length; i += 2)
            {
                string type = productsInformation[i];
                decimal price = decimal.Parse(productsInformation[i + 1]);
                try
                {
                    Product product = new Product(type, price);
                    products.Add(product);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] arguments = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string nameOfBuyer = arguments[0];
                string typeOfProduct = arguments[1];

                Person person = people.Single(p => p.Name == nameOfBuyer);
                Product product = products.Single(pr => pr.Type == typeOfProduct);

                Console.WriteLine(person.CanItBeBought(product));
                command = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person}");
            }
        }
    }
}
