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
    }
}
