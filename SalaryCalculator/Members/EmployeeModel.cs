using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class EmployeeModel : IMemberModel
    {
        public string Name { get; set; }
        public string Post { get; set; }
    }
}
