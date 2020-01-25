namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double extraConsumption = 0.9;

        public Car(double fuelQuantity, double consumptionPerKm)
            : base(fuelQuantity, consumptionPerKm)
        {
        }

        public override string Drive(double distance)
        {
            double fuelNeeded = (this.ConsumptionPerKm + extraConsumption) * distance;
            
            if (fuelNeeded <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;
                return $"Car travelled {distance} km";
            }

            return "Car needs refueling";
        }

        public override double Refuel(double fuel)
        {
            return this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.FuelQuantity:F2}";
        }
    }
}
