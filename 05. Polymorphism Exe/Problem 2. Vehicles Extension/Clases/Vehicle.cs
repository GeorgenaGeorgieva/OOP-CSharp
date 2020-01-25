namespace VehiclesExtension.Clases
{
    using System;
    using Interfaces;

    public abstract class Vehicle : IVehicle
    {
        private double tankCapacity;
        private double fuelQuantity;
        private double consumptionPerKm;

        public Vehicle(double fuelQuantity, double consumptionPerKm, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                this.FuelQuantity = 0;
            }
            else
            {
                this.FuelQuantity = fuelQuantity;
            }

            this.ConsumptionPerKm = consumptionPerKm;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            protected set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Fuel quantity must be positive number!");
                }

                this.fuelQuantity = value;
            }
        }

        public double ConsumptionPerKm
        {
            get { return this.consumptionPerKm; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid consumption!");
                }

                this.consumptionPerKm = value;
            }
        }

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Tank capacity must be positive number!");
                }

                this.tankCapacity = value;
            }
        }

        protected abstract double ExtraConsumption { get; }

        public virtual double Refuel(double fuel)
        {
            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            return this.FuelQuantity += fuel;
        }

        public abstract string Drive(double distance);
        
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}".ToString().TrimEnd();
        }
    }
}
