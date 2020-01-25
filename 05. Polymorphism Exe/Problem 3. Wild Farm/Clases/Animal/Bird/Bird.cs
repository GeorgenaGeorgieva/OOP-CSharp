namespace WildFarm.Clases.Animal.Bird
{
    using Interfaces;
    using System;

    public abstract class Bird : Animal, IBird
    {
        private double wingSize;

        public Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize
        {
            get { return this.wingSize; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid size of wings.");
                }

                this.wingSize = value;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]".ToString();
        }
    }
}
