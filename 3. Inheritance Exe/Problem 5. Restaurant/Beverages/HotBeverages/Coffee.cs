namespace Restaurant.Beverages.HotBeverages
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50M;
        private double coffeine;
        public Coffee(string name, double coffeine)  
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Coffeine = coffeine;
        }

        public double Coffeine
        {
            get
            {
                return this.coffeine;
            }
            protected set
            {
                this.coffeine = value;
            }
        }
    }
}
