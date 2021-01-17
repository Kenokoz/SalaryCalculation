using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class ReadingReport
    {
        public static void ReadReportAndSalary(IMember member)
        {
            try
            {
                StandardMessage.ReportForPeriod();

                CalcSalary.GetSalaryOfMember(member);

                StandardMessage.TotalHoursAndSalary(member);
            }
            catch (Exception)
            {
                ErrorMessage.IsNotCorrectDate(member);
                ReadReportAndSalary(member);
            }
        }
    }
}
