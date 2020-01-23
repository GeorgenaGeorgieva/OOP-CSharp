namespace MilitaryElite
{
    using Interfaces;
    using System;

    public class Soldier : ISoldier
    {
        private string id;
        private string firstName;
        private string lastName;

        public Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get { return this.id; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Id!");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid first name!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid last name!");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}".ToString().TrimEnd();
        }
    }
}
