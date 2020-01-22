namespace Animals
{
    using System;
    using System.Text;
    public class Animal
    {
        private string name;
        private int? age;
        private string gender;

        public Animal(string name, int? age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        {
            get
            {
                return this.name;
            } 
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }
        public int? Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value <= 0 || value == null)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }
        public string Gender
        {
            get
            {
                return this.gender;
            }
            protected set
            { 
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(this.GetType().Name);
            output.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            output.Append(this.ProduceSound());

            return output.ToString().TrimEnd();
        }
    }
}
