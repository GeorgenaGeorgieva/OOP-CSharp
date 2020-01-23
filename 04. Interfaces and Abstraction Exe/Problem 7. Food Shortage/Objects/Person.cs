namespace FoodShortage.Objects
{
    using Interfaces;
    using System;

    public abstract class Person : Creature, IName, IBuyer
    {
        private int age;
        private int food;

        public Person(string name, int age)
            :base(name)
        {
            this.Age = age;
            this.Food = food;
        }

        public int Age
        {
            get { return this.age; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age should be positive number!");
                }

                this.age = value;
            }
        }

        public int Food
        {
            get { return this.food; }
            protected set
            {
                if (food < 0)
                {
                    throw new ArgumentException("Amount of food must be positive number.");
                }

                this.food = value;
            }
        }

        public abstract int BuyFood();
    }
}
