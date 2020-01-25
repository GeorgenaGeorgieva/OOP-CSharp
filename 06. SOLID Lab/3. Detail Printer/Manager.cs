namespace P03.DetailPrinter
{
    using System.Collections.Generic;

    public class Manager : IEmployee
    {
        public Manager(string name, IReadOnlyCollection<string> documents)
        {
            this.Documents = documents;
            this.Name = name;
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public string Name { get; set; }
    }
}
