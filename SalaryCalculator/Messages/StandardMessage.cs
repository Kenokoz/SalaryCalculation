using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class StandardMessage
    {
        public static void GreetMessageForEmpAndFreelan(IMember member) 
        {
            Console.WriteLine($"Здравствуйте, {member.Name}!");
            Console.WriteLine($"Ваша роль: {member.Post}");
            Console.WriteLine("Выберите желаемое действие:");
            Console.WriteLine("(1). Добавить часы.");
            Console.WriteLine("(2). Просмотреть отчет и зарплату.");
            Console.WriteLine("(3). Выход из программы");
        }

        public static void EnterName()
        {
            Console.WriteLine("Введите ваше имя:");
        }

        public static void EnterFromDate()
        {
            Console.WriteLine("Введите с какого числа:");
        }

        public static void EnterToDate()
        {
            Console.WriteLine("Введите по какое число:");
        }
        public static void EnterDateToAddHours()
        {
            Console.WriteLine("Введите дату, в которую нужно добавить часы:");
        }

        public static void EnterAmountOfHours()
        {
            Console.WriteLine("Введите количество часов:");
        }

        public static void EnterWhatYouDid()
        {
            Console.WriteLine("Введите что делали:");
        }

        public static void ReportForPeriod()
        {
            Console.WriteLine($"Отчет за период с {DatePeriod.StartDate.ToShortDateString()} по " +
                    $"{DatePeriod.FinishDate.ToShortDateString()}");
        }

        public static void TotalHoursAndSalary(IMember member)
        {
            Console.WriteLine($"Итого: {member.Hours} часов," + $" заработано: {member.Salary} руб");
        }

        public static void MemberHoursAndSalaryForPeriod(IMember member)
        {
            Console.WriteLine($"{member.Name} отработал {member.Hours} часов и " +
                            $"заработал за период {member.Salary} руб");
        }

    }
}
