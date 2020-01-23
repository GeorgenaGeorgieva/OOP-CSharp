namespace FoodShortage.Objects
{
    using Interfaces;
    using System;

    public class Pet : Creature, IBirthdate
    {
        private DateTime birthdate;

        public Pet(string name, string birthdate)
            :base(name)
        {
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
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
    }
}
