using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class HeaderMessage : MemberMessage, IHeaderMessage
    {
        public override void GreetMessage(IMember header)
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

        public void EnterNameOfMember()
        {
            Console.WriteLine("Введите имя сотрудника:");
        }
    }
}
