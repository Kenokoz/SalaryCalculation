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
            Console.WriteLine("Введите имя сотрудника:");
            string name = ValidInputValue.GetName();

            Console.WriteLine($"Отчет за период с {DatePeriod.StartDate.ToShortDateString()} по " +
                    $"{DatePeriod.FinishDate.ToShortDateString()}");

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
                    Console.WriteLine($"{member.Name} отработал {member.Hours} часов и " +
                                $"заработал за период {member.Salary} руб");
                    break;
                }
            }
        }
    }
}
