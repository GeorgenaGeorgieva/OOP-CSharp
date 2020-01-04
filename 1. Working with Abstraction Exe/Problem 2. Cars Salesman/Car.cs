namespace CarsSalesman
{
    using System.Text;
    public class Car
    {
        private const string offset = "  "; 

        private string model;
        private Engine engine;
        private int? weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int? weight)
            : this(model, engine)
        {
            this.Weight = (int)weight;
        }

        public Car(string model, Engine engine, string color)
            : this (model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, int? weight, string color)
            : this(model, engine)
        {
            this.Weight = (int)weight;
            this.Color = color;
        }

        public string Model 
        {
            get { return this.model; }
            private set { this.model = value; } 
        }
        public Engine Engine 
        {
            get { return this.engine; }
            private set { this.engine = value; } 
        }
        public int? Weight 
        {
            get { return this.weight; }
            private set { this.weight = value; } 
        }
        public string Color 
        {
            get { return this.color; }
            private set { this.color = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Model}:\n");
            sb.Append(this.Engine);
            sb.AppendLine($"{offset}Weight: {(this.Weight == null ? "n/a" : this.Weight.ToString())}");
            sb.Append($"{offset}Color: {(this.Color == null ? "n/a" : this.Color.ToString())}");

            return sb.ToString();
        }
    }
}
