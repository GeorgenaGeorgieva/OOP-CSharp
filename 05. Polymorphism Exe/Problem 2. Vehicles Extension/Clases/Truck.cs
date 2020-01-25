namespace VehiclesExtension.Clases
{

    public class Truck : Vehicle
    {
        private const double ChangeInConsumption = 1.6;
        private const double LeftPercentFuel = 0.95;

        public Truck(double fuelQuantity, double consumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, consumptionPerKm, tankCapacity)
        {
        }

        protected override double ExtraConsumption => ChangeInConsumption;

        public override string Drive(double distance)
        {
            double fuelNeeded = (this.ConsumptionPerKm + this.ExtraConsumption) * distance;

            if (fuelNeeded <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public override double Refuel(double fuel)
        {
           return base.Refuel(fuel) * LeftPercentFuel; 
        }
    }
}
