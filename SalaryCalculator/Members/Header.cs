using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class Header : IMember
    {
        public string Name { get; set; }
        public string Post { get; set; }
        public IMemberMessage ShowMessage { get; set; } = new HeaderMessage();
        public IAction Action { get; set; }
        public int Hours { get; set; }
        public int Salary { get; set; }
    }
}
