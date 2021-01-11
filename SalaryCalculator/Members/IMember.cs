using System.Collections.Generic;

namespace SalaryCalculator
{
    public interface IMember
    {
        string Name { get; set; }
        string Post { get; set; }
        IMemberMessage ShowMessage { get; set; }
        IAction Action { get; set; }
        int Hours { get; set; }
        int Salary { get; set; }
    }
}