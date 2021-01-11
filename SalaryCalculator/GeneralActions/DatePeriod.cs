using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class DatePeriod
    {
        public static DateTime StartDate { get; private set; } = GetStartDate();
        public static DateTime FinishDate { get; private set; } = GetFinishDate();

        private static DateTime GetStartDate()
        {
            StandardMessage.EnterFromDate();
            DateTime dateStart = DateTime.Parse(Console.ReadLine());
            return dateStart;
        }

        private static DateTime GetFinishDate()
        {
            StandardMessage.EnterToDate();
            DateTime dateFinish = DateTime.Parse(Console.ReadLine());
            return dateFinish;
        }
    }
}
