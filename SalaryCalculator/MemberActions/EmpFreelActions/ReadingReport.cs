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
                Console.WriteLine($"Отчет по сотруднику: {member.Name} за период с {DatePeriod.StartDate.ToShortDateString()} " +
                    $"по {DatePeriod.FinishDate.ToShortDateString()}");

                CalcSalary.GetSalaryOfMember(member);

                Console.WriteLine($"Итого: {member.Hours} часов," + $" заработано: {member.Salary} руб");
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный ввод даты! Попробуйте еще раз.");
                ReadReportAndSalary(member);
            }
        }
    }
}
