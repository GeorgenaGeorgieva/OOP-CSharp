namespace FoodShortage.Objects
{
    using Interfaces;
    using System;

    public class Creature : IName
    {
        private string name;

        public Creature(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Invalid name!");
                }

                this.name = value;
            }
        }
    }
}
