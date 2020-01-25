namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double extraConsumption = 1.6;
        private const double leftPercentFuel = 0.95;
        public Truck(double fuelQuantity, double consumptionPerKm) 
            : base(fuelQuantity, consumptionPerKm)
        {
        }

        public override string Drive(double distance)
        {
            double fuelNeeded = (this.ConsumptionPerKm + extraConsumption) * distance;

            if (fuelNeeded <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;
                return $"Truck travelled {distance} km";
            }

            return "Truck needs refueling";
        }

        public override double Refuel(double fuel)
        {
            return this.FuelQuantity += fuel * leftPercentFuel;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.FuelQuantity:F2}";
        }
    }
}
