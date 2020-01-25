namespace Vehicles
{
    using System;
    using Interfaces;

    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double consumptionPerKm;

        public Vehicle(double fuelQuantity, double consumptionPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.ConsumptionPerKm = consumptionPerKm;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid fuel quantity");
                }

                this.fuelQuantity = value;
            }
        }

        public double ConsumptionPerKm
        {
            get { return this.consumptionPerKm; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid consumption!");
                }

                this.consumptionPerKm = value;
            }
        }

        public abstract string Drive(double distance);
        public abstract double Refuel(double fuel);

        public override string ToString()
        {
            return $"{this.GetType().Name}: ";
        }
    }
}
