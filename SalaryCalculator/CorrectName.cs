using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class CorrectName
    {
        public static string GetName()
        {
            string name = Console.ReadLine().Trim();
            string result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            return result;
        }
    }
}
