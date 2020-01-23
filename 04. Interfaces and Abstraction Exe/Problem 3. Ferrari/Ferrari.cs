namespace Ferrari
{
    using System;

    public class Ferrari : ICar
    {
        private string driver;

        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
        }

        public string Model { get; }

        public string Driver
        {
            get { return this.driver; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid driver name!");
                }

                this.driver = value;
            }
        }

        public string Start()
        {
            return "Gas!";
        }

        public string Stop()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Stop()}/{this.Start()}/{this.Driver}".ToString();
        }
    }
}
