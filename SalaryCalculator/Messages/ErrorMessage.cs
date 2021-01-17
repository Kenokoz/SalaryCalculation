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

        public static void CanNotAddHoursBeforeTwoDays()
        {
            Console.WriteLine("Вы не можете добавлять часы раньше, чем за 2 дня");
        }

        public static void IsNotCorrectDate(IMember member)
        {
            Console.WriteLine($"Итого: {member.Hours} часов," + $" заработано: {member.Salary} руб");
        }

        public static void PostNotExist()
        {
            Console.WriteLine("Такой должности не существует. Повторите попытку.");
        }

        public static void MemberExists()
        {
            Console.WriteLine("Такое имя уже записано!");
        }

        public static void WrongAction()
        {
            Console.WriteLine("Неверное действие. Нажмите enter, чтобы повторить попытку");
        }
    }
}
