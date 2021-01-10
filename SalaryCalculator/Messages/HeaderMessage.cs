using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class HeaderMessage : IMemberMessage
    {
        public void GreetMessage(IMember member)
        {
            Console.WriteLine($"Здравствуйте, {member.Name}!");
            Console.WriteLine($"Ваша роль: {member.Post}");
            Console.WriteLine("Выберите желаемое действие:");
            Console.WriteLine("(1). Добавить сотрудника");
            Console.WriteLine("(2). Просмотреть отчет по всем сотрудникам");
            Console.WriteLine("(3). Просмотреть отчет по конкретному сотруднику");
            Console.WriteLine("(4). Добавить часы работы");
            Console.WriteLine("(5). Выход из программы");
        }
    }
}
