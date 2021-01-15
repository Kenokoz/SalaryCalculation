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
            Console.WriteLine($"Отчет за период с {DatePeriod.StartDate.ToShortDateString()} по " +
                    $"{DatePeriod.FinishDate.ToShortDateString()}");

            foreach (var member in MembersInCompany.members)
            {
                foreach (var report in MembersInCompany.reportOfMembers)
                {
                    string[] dataOfReport = report.Split(new char[] { ',' });

                    if (dataOfReport[1].Contains(member.Name))
                    {
                        CalcSalary.GetSalaryOfMember(member);
                        
                    }
                }
                Console.WriteLine($"{member.Name} отработал {member.Hours} часов и " +
                            $"заработал за период {member.Salary} руб");
            }

        }

    }
}
