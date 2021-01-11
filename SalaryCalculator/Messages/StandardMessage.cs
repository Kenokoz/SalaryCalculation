using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class StandardMessage
    {
        public static void EnterName()
        {
            Console.WriteLine("Введите ваше имя:");
        }

        public static void MemberIsNotExists()
        {
            Console.WriteLine("Такого сотрудника не существует. Повторите попытку.");
        }

        public static void EnterFromDate()
        {
            Console.WriteLine("Введите с какого числа:");
        }

        public static void EnterToDate()
        {
            Console.WriteLine("Введите по какое число:");
        }
    }
}
