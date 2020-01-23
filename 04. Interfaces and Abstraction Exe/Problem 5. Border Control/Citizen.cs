namespace BorderControl
{
    using System;

    public class Citizen : IIdentifiable
    {
        private string name;
        private int age;
        private string id;

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name!");
                }

                this.name = value;
            }
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
