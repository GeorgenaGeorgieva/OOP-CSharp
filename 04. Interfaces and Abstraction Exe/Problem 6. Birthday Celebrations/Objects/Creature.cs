namespace BirthdayCelebrations.Objects
{
    using Interfaces;
    using System;

    public class Creature : IAlive
    {
        private string name;
        private string birthdate;

        public Creature(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get { return this.Name; }
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name!");
                }

                this.name = value;
            }
        }

        public string Birthdate
        {
            get { return this.birthdate; }
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid birthdate!");
                }

                this.birthdate = value;
            }
        }
    }
}
