namespace ProblemPerson
{
    using System.Text;
     
    public class Person
    {
        private int age;

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public string Name { get; set; }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}".ToString();
        }
    }
}
