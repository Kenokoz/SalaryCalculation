using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class ReadingMemberReport
    {
        public static void ReadMemberReport()
        {
            HeaderMessage.EnterNameOfMember();
            string name = ValidInputValue.GetName();

            foreach (var member in ReaderMembersAndReports.members)
            {
                if (member.Name == name)
                {
                    StandardMessage.ReportForPeriod();

                    foreach (var report in ReaderMembersAndReports.reportOfMembers)
                    {
                        string[] dataOfReport = report.Split(new char[] { ',' });

                        if (dataOfReport[1].Contains(member.Name))
                        {
                            CalcSalary.GetSalaryOfMember(member);

                        }
                    }
                    StandardMessage.MemberHoursAndSalaryForPeriod(member);
                    return;
                }
            }

            ErrorMessage.MemberIsNotExists();
            ReadMemberReport();
        }
    }
}
