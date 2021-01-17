using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class ReadingAllReports
    {
        static public void ReadAllReport()
        {
            StandardMessage.ReportForPeriod();

            foreach (var member in ReaderMembersAndReports.members)
            {
                foreach (var report in ReaderMembersAndReports.reportOfMembers)
                {
                    string[] dataOfReport = report.Split(new char[] { ',' });

                    if (dataOfReport[1].Contains(member.Name))
                    {
                        CalcSalary.GetSalaryOfMember(member);
                        
                    }
                }
                StandardMessage.MemberHoursAndSalaryForPeriod(member);
            }

        }

    }
}
