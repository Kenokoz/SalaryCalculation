using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public static class HeaderMessage
    {
        public static void GreetMessageForHeader(IMember header)
        {
            Console.WriteLine($"Здравствуйте, {header.Name}!");
            Console.WriteLine($"Ваша роль: {header.Post}");
            Console.WriteLine("Выберите желаемое действие:");
            Console.WriteLine("(1). Добавить сотрудника");
            Console.WriteLine("(2). Просмотреть отчет по всем сотрудникам");
            Console.WriteLine("(3). Просмотреть отчет по конкретному сотруднику");
            Console.WriteLine("(4). Добавить часы работы");
            Console.WriteLine("(5). Выход из программы");
        }

        public static void EnterNameOfMember()
        {
            Console.WriteLine("Введите имя сотрудника:");
        }

        public static void EnterWhatMemberDid()
        {
            Console.WriteLine("Введите что делал сотрудник:");
        }

        public static void EnterPostOfMember()
        {
            Console.WriteLine("Введите должность сотрудника ('header', 'employee', 'freelancer'):");
        }

        public static void MemberReportForPeriod(IMember member)
        {
            Console.WriteLine($"Отчет по сотруднику: {member.Name} за период с {DatePeriod.StartDate.ToShortDateString()} " +
                    $"по {DatePeriod.FinishDate.ToShortDateString()}");
        }

        public static void MemberAdded()
        {
            Console.Write("Сотрудник успешно добавлен.");
        }
    }
}
