using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class FreelancerMessage : IMemberMessage
    {
        public void GreetMessage(IMember member)
        {
            Console.WriteLine($"Здравствуйте, {member.Name}!");
            Console.WriteLine($"Ваша роль: {member.Post}");
            Console.WriteLine("Выберите желаемое действие:");
            Console.WriteLine("(1). Добавить часы.");
            Console.WriteLine("(2). Просмотреть отчет и зарплату.");
            Console.WriteLine("(3). Выход из программы");
        }
    }
}
