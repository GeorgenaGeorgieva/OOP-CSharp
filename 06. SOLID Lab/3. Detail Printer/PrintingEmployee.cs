namespace P03.DetailPrinter
{
    using P03.DetailPrinter;
    using System.Collections.Generic;
    public class PrintingEmployee : DetailsPrinter
    {
        public PrintingEmployee(IList<IEmployee> employees) 
            : base(employees)
        {
        }

        protected override string Print(IEmployee employee)
        {
            var currentEmployee = employee as Employee;
            return currentEmployee.Name;
        }
    }
}
