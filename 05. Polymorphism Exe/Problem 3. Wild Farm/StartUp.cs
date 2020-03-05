namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using Clases.Animal;
    using Clases.Animal.Bird;
    using Clases.Animal.Mammal;
    using Clases.Animal.Mammal.Feline;
    using Clases.Food;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] arguments = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    Animal animal = CreateAnimal(arguments);
                    animals.Add(animal);

                    arguments = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    Food food = CreateFood(arguments);

                    Console.WriteLine(animal.ProduceSoundAskForFood());
                    animal.FeedAnimal(food);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                input = Console.ReadLine();
            }

            animals.ForEach(Console.WriteLine);
        }

        private static Animal CreateAnimal(string[] arguments)
        {

            string type = arguments[0];
            string name = arguments[1];
            double weight = double.Parse(arguments[2]);

            if (type is nameof(Owl))
            {
                double wingSize = double.Parse(arguments[3]);
                Animal owl = new Owl(name, weight, wingSize);
                return owl;
            }
            else if (type is nameof(Hen))
            {
                double wingSize = double.Parse(arguments[3]);
                Animal hen = new Hen(name, weight, wingSize);
                return hen;
            }
            else if (type is nameof(Cat))
            {
                string livingRegion = arguments[3];
                string breed = arguments[4];
                Animal cat = new Cat(name, weight, livingRegion, breed);
                return cat;
            }
            else if (type is nameof(Tiger))
            {
                string livingRegion = arguments[3];
                string breed = arguments[4];
                Animal tiger = new Tiger(name, weight, livingRegion, breed);
                return tiger;
            }
            else if (type is nameof(Dog))
            {
                string livingRegion = arguments[3];
                Animal dog = new Dog(name, weight, livingRegion);
                return dog;
            }
            else if (type is nameof(Mouse))
            {
                string livingRegion = arguments[3];
                Animal mouse = new Mouse(name, weight, livingRegion);
                return mouse;
            }

            return null;
        }

        private static Food CreateFood(string[] arguments)
        {

            string type = arguments[0];
            int quantity = int.Parse(arguments[1]);

            if (type is nameof(Vegetable))
            {
                Food vegetable = new Vegetable(quantity);
                return vegetable;
            }
            else if (type is nameof(Fruit))
            {
                Food fruit = new Fruit(quantity);
                return fruit;
            }
            else if (type is nameof(Meat))
            {
                Food meat = new Meat(quantity);
                return meat;
            }
            else if (type is nameof(Seeds))
            {
                Food seeds = new Seeds(quantity);
                return seeds;
            }

            return null;
        }
    }
}
