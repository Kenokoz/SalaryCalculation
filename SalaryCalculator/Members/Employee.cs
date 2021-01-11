using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class Employee : IMember
    {
        public string Name { get;set; }
        public string Post { get; set; }
        public IMemberMessage ShowMessage { get; set; } = new EmployeeMessage();
        public IAction Action { get; set; } = new Action();
        public int Hours { get; set; } 
        public int Salary { get; set; }
    }
}
