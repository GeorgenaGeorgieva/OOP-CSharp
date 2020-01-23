namespace MilitaryElite
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<Mission> missions;

        public Commando(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<Mission>();
        }

        public IReadOnlyCollection<IMission> Missions
        {
            get { return this.missions; }
        }

        public void AddMission(Mission mission)
        {
            if (mission.State != "finished")
            {
                this.missions.Add(mission);
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString())
                .AppendLine("Missions:");

            foreach (var mission in this.Missions)
            {
                stringBuilder.AppendLine(mission.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
