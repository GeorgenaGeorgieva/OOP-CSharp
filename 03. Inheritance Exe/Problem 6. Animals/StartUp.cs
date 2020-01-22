namespace Animals
{
    using Cats;
    using Dogs;
    using Frogs;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>();

            var inputLine = Console.ReadLine();

            while (inputLine != "Beast!")
            {
                var typeAnimal = inputLine;

                var animalInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = animalInformation[0];
                var age = int.Parse(animalInformation[1]);
                var gender = animalInformation[2];

                try
                {
                    if (typeAnimal == "Cat")
                    {
                        animals.Add(new Cat(name, age, gender));
                    }
                    else if (typeAnimal == "Dog")
                    {
                        animals.Add(new Dog(name, age, gender));
                    }
                    else if (typeAnimal == "Frog")
                    {
                        animals.Add(new Frog(name, age, gender));
                    }
                    else if (typeAnimal == "Kitten")
                    {
                        animals.Add(new Kitten(name, age));
                    }
                    else if (typeAnimal == "Tomcat")
                    {
                        animals.Add(new Tomcat(name, age));
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                inputLine = Console.ReadLine();
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
