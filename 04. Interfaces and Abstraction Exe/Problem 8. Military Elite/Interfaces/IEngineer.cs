namespace MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<Repair> Repairs { get; }
        void AddRepair(Repair repair);
    }
}
