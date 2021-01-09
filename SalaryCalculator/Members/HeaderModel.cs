using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class HeaderModel : IMemberModel
    {
        public string Name { get; set; }
        public string Post { get; set; }
        public List<string> Headers { get; set; }
    }
}
