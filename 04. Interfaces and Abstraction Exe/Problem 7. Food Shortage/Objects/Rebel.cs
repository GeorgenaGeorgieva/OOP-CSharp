namespace FoodShortage.Objects
{
    using System;

    public class Rebel : Person
    {
        private string group;

        public Rebel(string name, int age, string group)
            : base(name, age)
        {
            this.Group = group;
        }

        public string Group
        {
            get { return this.group; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Invalid group name!");
                }

                this.group = value;
            }
        }

        public override int BuyFood()
        {
            this.Food += 5;
            return this.Food;
        }
    }
}
