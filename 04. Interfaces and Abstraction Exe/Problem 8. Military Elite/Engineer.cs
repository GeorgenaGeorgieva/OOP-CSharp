namespace MilitaryElite
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<Repair>();
        }

        public IReadOnlyCollection<Repair> Repairs
        {
            get { return this.repairs; }
        }

        public void AddRepair(Repair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                builder.AppendLine(repair.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
