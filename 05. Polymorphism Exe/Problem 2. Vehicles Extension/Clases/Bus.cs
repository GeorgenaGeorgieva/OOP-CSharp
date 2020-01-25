namespace VehiclesExtension.Clases
{
    using Enum;

    public class Bus : Vehicle
    {
        private const double ChangeInConsumption = 1.4;
        private StateAirConditioner state;

        public Bus(double fuelQuantity, double consumptionPerKm, double tankCapacity)
            : base(fuelQuantity, consumptionPerKm, tankCapacity)
        {
            this.state = StateAirConditioner.On;
        }

        protected override double ExtraConsumption
            => this.state == StateAirConditioner.On
            ? ChangeInConsumption
            : (double)StateAirConditioner.Off;

        public void DriveEmpty()
        {
            this.state = StateAirConditioner.Off;
        }

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
