namespace MilitaryElite
{
    using Interfaces;
    using System;

    public class Private : Soldier, IPrivate
    {
        private decimal salary;

        public Private(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary
        {
            get { return this.salary; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary sould be positive number!");
                }

                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:F2}".ToString().TrimEnd();
        }
    }
}
