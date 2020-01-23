namespace MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
        void AddPrivate(Private newPrivate);
    }
}
