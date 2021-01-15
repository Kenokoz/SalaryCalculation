using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public static class ErrorMessage
    {
        public static void MemberIsNotExists()
        {
            Console.WriteLine("Такого сотрудника не существует. Повторите попытку.");
        }

        public static void InputNameIsNotCorrect()
        {
            Console.WriteLine("Введите корректное имя.");
        }

        public static void InputPostIsNotCorrect()
        {
            Console.WriteLine("Введите корректную должность.");
        }
    }
}
