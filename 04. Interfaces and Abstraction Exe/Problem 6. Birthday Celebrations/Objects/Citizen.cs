namespace BirthdayCelebrations.Objects
{
    using Interfaces;
    using System;

    public class Citizen : Creature, IIdentifiable
    {
        private int age;
        private string id;

        public Citizen(string name, int age, string id, string birthdate)
            :base(name, birthdate)
        {
            this.Age = age;
            this.Id = id;
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age should be positive number!");
                }

                this.age = value;
            }
        }

        public string Id
        {
            get { return this.id; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid ID!");
                }

                this.id = value;
            }
        }
    }
}
