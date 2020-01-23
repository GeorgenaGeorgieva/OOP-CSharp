namespace MilitaryElite
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<Private> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<Private>();
        }

        public IReadOnlyCollection<IPrivate> Privates
        {
            get { return this.privates; }
        }

        public void AddPrivate(Private newPrivate)
        {
            this.privates.Add(newPrivate);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var current in this.Privates)
            {
                builder.AppendLine("  " + current.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
