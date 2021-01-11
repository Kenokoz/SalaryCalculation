using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class MemberMessage : IMemberMessage
    {
        public virtual void GreetMessage(IMember member)
        {
            Console.WriteLine($"Здравствуйте, {member.Name}!");
            Console.WriteLine($"Ваша роль: {member.Post}");
            Console.WriteLine("Выберите желаемое действие:");
        }

        public void EnterDateToAddHours()
        {
            Console.WriteLine("Введите дату, в которую нужно добавить часы:");
        }

        public void EnterAmountOfHours()
        {
            Console.WriteLine("Введите количество часов:");
        }

        public void EnterWhatDid()
        {
            Console.WriteLine("Введите что делали:");
        }

    }
}
