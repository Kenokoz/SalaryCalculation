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

            StandardMessage.ReportForPeriod();

            foreach (var member in MembersInCompany.members)
            {
                if (member.Name == name)
                {
                    foreach (var report in MembersInCompany.reportOfMembers)
                    {
                        string[] dataOfReport = report.Split(new char[] { ',' });

                        if (dataOfReport[1].Contains(member.Name))
                        {
                            CalcSalary.GetSalaryOfMember(member);

                        }
                    }
                    HeaderMessage.MemberHoursAndSalaryForPeriod(member);
                    break;
                }
            }
        }
    }
}
