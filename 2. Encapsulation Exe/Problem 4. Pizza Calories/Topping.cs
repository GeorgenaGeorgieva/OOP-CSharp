namespace PizzaCalories
{
    using System;
    public class Topping
    {
        private const double CALORIES_GRAM = 2;
        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get 
            {
                return this.type; 
            }
            private set
            {
                if (value.ToLower() != "meat" 
                    && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese"
                    && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public int Weight
        {
            get 
            {
                return this.weight; 
            }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range[1..50].");
                }

                this.weight = value;
            }
        }

        public double CalculateToppingsCalories()
        {
            double modifier = CALORIES_GRAM;

            if (this.Type.ToLower() == "meat")
            {
                modifier *= 1.2;
            }
            else if (this.Type.ToLower() == "veggies")
            {
                modifier *= 0.8;
            }
            else if (this.Type.ToLower() == "cheese")
            {
                modifier *= 1.1;
            }
            else if (this.Type.ToLower() == "sauce")
            {
                modifier *= 0.9;
            }

            double calories = modifier * this.Weight;
            return calories;
        }
    }
}
