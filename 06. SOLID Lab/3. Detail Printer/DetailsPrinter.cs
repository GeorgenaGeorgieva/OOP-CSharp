namespace P03.DetailPrinter
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class DetailsPrinter 
    {
        private IList<IEmployee> employees;

        public DetailsPrinter(IList<IEmployee> employees)
        {
            this.employees = employees;
        }

        public string PrintDetails()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (IEmployee employee in this.employees)
            {
                stringBuilder.AppendLine(this.Print(employee)); 
            }

            return stringBuilder.ToString();
        }

        protected abstract string Print(IEmployee employee); 
    }
}
