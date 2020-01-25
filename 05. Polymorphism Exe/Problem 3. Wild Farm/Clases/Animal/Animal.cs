namespace WildFarm.Clases.Animal
{
    using Interfaces;
    using System;
    using WildFarm.Clases.Food;

    public abstract class Animal : IAnimal
    {
        private string name;
        private double weight;
        private int foodEaten;

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Invalid name of {this.GetType().Name}.");
                }

                this.name = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Invalid {this.GetType().Name} weight.");
                }

                this.weight = value;
            }
        }

        protected int FoodEaten
        {
            get { return this.foodEaten; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid amount of food.");
                }

                this.foodEaten = value;
            }
        }

        protected abstract double WeightGain { get; }

        protected abstract bool PreferredFood(Food food);

        public abstract string ProduceSoundAskForFood();

        public virtual void FeedAnimal(Food food)
        {
            if (!PreferredFood(food))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                this.Weight += food.Quantity * this.WeightGain;
                this.FoodEaten += food.Quantity;
            }
        }
    }
}
