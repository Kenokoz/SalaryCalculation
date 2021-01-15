using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class MemberMessage : IMemberMessage
    {
        public virtual void GreetMessage(IMember member) { }

        public void EnterDateToAddHours()
        {
            Console.WriteLine("Введите дату, в которую нужно добавить часы:");
        }

        public void EnterAmountOfHours()
        {
            Console.WriteLine("Введите количество часов:");
        }

        public void EnterWhatYouDid()
        {
            Console.WriteLine("Введите что делали:");
        }

    }
}
