namespace FoodShortage.Objects
{
    using Interfaces;
    using System;

    public class Citizen : Person, IIdentifiable, IBirthdate
    {
        private string id;
        private DateTime birthdate;

        public Citizen(string name, int age, string id, string birthdate)
            : base(name, age)
        {
            this.Id = id;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
        }

        public string Id
        {
            get { return this.id; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentException("Invalid ID!");
                }

                this.id = value;
            }
        }

        public DateTime Birthdate
        {
            get { return this.birthdate; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Birthdate is compulsory!");
                }

                this.birthdate = value;
            }
        }

        public override int BuyFood()
        {
            this.Food += 10;
            return this.Food;
        }
    }
}
