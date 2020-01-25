namespace VehiclesExtension.Clases
{
    public class Car : Vehicle
    {
        private const double ChangeInConsumption = 0.9;

        public Car(double fuelQuantity, double consumptionPerKm, double tankCapacity)
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
    }
}
