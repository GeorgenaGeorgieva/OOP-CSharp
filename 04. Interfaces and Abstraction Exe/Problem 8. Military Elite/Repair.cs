namespace MilitaryElite
{
    using Interfaces;
    using System;

    public class Repair : IRepair
    {
        private string partName;
        private int workedHours;

        public Repair(string partName, int workedHours)
        {
            this.PartName = partName;
            this.WorkedHours = workedHours;
        }
        public string PartName 
        {
            get{return this.partName; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid part name.");
                }

                this.partName = value;
            }
        }

        public int WorkedHours
        {
            get { return this.workedHours; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Worked hours should be zero or positive number.");
                }

                this.workedHours = value;
            }
        }

        public override string ToString()
        {
            return $"  Part Name: {this.PartName} Hours Worked: {this.WorkedHours}".ToString().TrimEnd();
        }
    }
}
