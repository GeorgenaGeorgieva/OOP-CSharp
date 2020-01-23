namespace MilitaryElite
{
    using Interfaces;
    using System;

    public class Mission : IMission
    {
        private string codeName;
        private StateMission state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName
        {
            get { return this.codeName; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid code name!");
                }

                this.codeName = value;
            }
        }

        public string State
        {
            get { return this.state.ToString(); }
            private set
            {
                StateMission state = new StateMission();

                if (!Enum.TryParse<StateMission>(value, out state))
                {
                    throw new ArgumentException("Invalid state!");
                }

                this.state = state;
            }
        }

        public void CompleteMission()
        {
            this.state = StateMission.finished;
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}".ToString().TrimEnd();
        }
    }
}
