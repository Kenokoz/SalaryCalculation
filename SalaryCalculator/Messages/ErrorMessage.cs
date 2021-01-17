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

        public static void InputHourIsNotCorrect()
        {
            Console.WriteLine("Введите корректное количество часов (цифра).");
        }

        public static void InputPostIsNotCorrect()
        {
            Console.WriteLine("Введите корректную должность.");
        }

        public static void InputAnswerIsNotCorrect()
        {
            Console.WriteLine("Введите корректный ответ.");
        }

        public static void CanNotAddHoursBeforeTwoDays()
        {
            Console.WriteLine("Вы не можете добавлять часы раньше, чем за 2 дня.");
        }

        public static void IsNotCorrectDate()
        {
            Console.WriteLine("Введите корректную дату.");
        }

        public static void PostNotExist()
        {
            Console.WriteLine("Такой должности не существует. Повторите попытку.");
        }

        public static void MemberIsWritten()
        {
            Console.WriteLine("Такое имя уже записано! Повторите попытку.");
        }

        public static void WrongAction()
        {
            Console.WriteLine("Неверное действие. Нажмите enter, чтобы повторить попытку.");
        }

        
    }
}
