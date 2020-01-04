namespace CarsSalesman
{
    using System.Text;
    public class Engine
    {
        private const string offset = "  ";

        private string model;
        private int power;
        private int? displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, int? displacement)
            :this(model, power)
        {
            this.Displacement = (int)displacement;
        }

        public Engine(string model, int power, string efficiency)
            :this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int? displacement, string efficiency)
            :this(model, power)
        {
            this.Displacement = (int)displacement;
            this.Efficiency = efficiency;
        }

        public string Model 
        {
            get { return this.model; }
            private set { this.model = value; } 
        }

        public int Power 
        {
            get { return this.power; }
            private set { this.power = value; }
        }

        public int? Displacement
        {
            get { return this.displacement; }
            private set { this.displacement = value; }
        }

        public string Efficiency 
        {
            get { return this.efficiency; }
            private set { this.efficiency = value; } 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{offset}{this.Model}:");
            sb.AppendLine($"{offset}{offset}Power: {this.Power}");
            sb.AppendLine($"{offset}{offset}Displacement: {(this.Displacement == null ? "n/a" : this.Displacement.ToString())}");
            sb.AppendLine($"{offset}{offset}Efficiency: {(this.Efficiency == null ? "n/a" : this.Efficiency.ToString())}");

            return sb.ToString();
        }
    }
}
