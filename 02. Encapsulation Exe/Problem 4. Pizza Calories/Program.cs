namespace PizzaCalories
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] pizzaOrder = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] supplements = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                string name = pizzaOrder[1];

                string flourType = supplements[1];
                string backingTechnique = supplements[2];
                int weight = int.Parse(supplements[3]);

                Dough dough = new Dough(flourType, backingTechnique, weight);
                Pizza pizza = new Pizza(name, dough);

                string command = Console.ReadLine();

                while (command != "END")
                {
                    supplements = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string type = supplements[1];
                    int weightTopping = int.Parse(supplements[2]);

                    Topping topping = new Topping(type, weightTopping);
                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                pizza.CalculatePizzaCalories();
                Console.WriteLine(pizza);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
