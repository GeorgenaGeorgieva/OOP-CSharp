namespace MilitaryElite
{
    using Interfaces;
    using System.Text;

    public class Spy : Soldier, ISpy
    {
        private int codeNumber;

        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber
        {
            get { return this.codeNumber; }
            private set
            {
                this.codeNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .Append($"Code Number: {this.CodeNumber}");

            return builder.ToString();
        }
    }
}
