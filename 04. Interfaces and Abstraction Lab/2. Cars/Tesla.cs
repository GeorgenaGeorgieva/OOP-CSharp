namespace Cars
{
    using System;

    public class Tesla : Car, IElectricCar
    {
        private int batteries;

        public Tesla(string model, string color, int batteries)
            : base(model, color)
        {
            this.Batteries = batteries;
        }

        public int Batteries
        {
            get { return this.batteries; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of batteries should be positive number!");
                }

                this.batteries = value;
            }
        }

        protected override string GetCarInformation()
        {
            return base.GetCarInformation() + $" with {this.Batteries} Batteries";
        }
    }
}
