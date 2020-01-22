namespace Cars
{
    using System;
    using System.Text;

    public abstract class Car : ICar
    {
        private string model;
        private string color;

        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model
        {
            get { return this.model; }
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.model = value;
            }
        }

        public string Color
        {
            get { return this.color; }
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.color = value;
            }
        }

        public string Start()
        {
            return $"Engine start";
        }

        public string Stop()
        {
            return $"Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(GetCarInformation());
            stringBuilder.AppendLine(this.Start());
            stringBuilder.Append(this.Stop());

            return stringBuilder.ToString().TrimEnd();
        }

        protected virtual string GetCarInformation()
        {
            return $"{this.Color} {this.GetType().Name} {this.Model}";
        }
    }
}
