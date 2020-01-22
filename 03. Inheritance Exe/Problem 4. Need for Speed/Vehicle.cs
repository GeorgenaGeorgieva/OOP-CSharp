﻿namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        private int horsePower;
        private double fuel;
        private double fuelConsumption;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public virtual double FuelConsumption { get; set; }

        public virtual void Drive(double kilometers)
        {
            bool canDrive = this.Fuel - this.FuelConsumption * kilometers >= 0;

            if (canDrive)
            {
                this.Fuel -= this.FuelConsumption * kilometers;
            }
        }
    }
}
