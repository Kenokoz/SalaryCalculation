using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class ValidInputValue
    {
        public static string GetName()
        {
            while (true)
            {
                string name = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    ErrorMessage.InputNameIsNotCorrect();
                }
                else
                {
                    string correctName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
                    return correctName;
                }
            }
        }

        public static string GetPost()
        {
            while (true)
            {
                string post = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(post))
                {
                    ErrorMessage.InputPostIsNotCorrect();
                }
                else
                {
                    return post;
                }
            }
        }

        public static int GetHours()
        {
            try
            {
                int hours = int.Parse(Console.ReadLine());
                return hours;
            }
            catch (Exception)
            {
                ErrorMessage.InputHourIsNotCorrect();
                GetHours();
            }
            return -1;
        }

        public static DateTime GetDate()
        {
            DateTime date = DateTime.Now;
            try
            {
                date = DateTime.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                ErrorMessage.IsNotCorrectDate();
                GetDate();
            }

            return date;
        }

    }
}
