namespace P03.DetailPrinter
{
    using System.Collections.Generic;
    using System.Text;

    public class PrintingManager : DetailsPrinter
    {
        public PrintingManager(IList<IEmployee> employees) 
            : base(employees)
        {
        }

        protected override string Print(IEmployee employee)
        {
            var currentManager = employee as Manager;

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var data in currentManager.Documents)
            {
                stringBuilder.AppendLine(data);
            }

            return $"{currentManager.Name}\n{stringBuilder.ToString()}" ;
        }
    }
}
