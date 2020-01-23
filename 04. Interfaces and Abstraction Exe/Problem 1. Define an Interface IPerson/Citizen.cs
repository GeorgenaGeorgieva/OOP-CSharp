namespace PersonInfo
{
    using System;
    using System.Text;

    public class Citizen : IPerson
    {
        private string name;
        private int age;

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new AggregateException("Invalid name!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age should be positive number!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{this.Name}");
            stringBuilder.Append($"{this.Age}");
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
