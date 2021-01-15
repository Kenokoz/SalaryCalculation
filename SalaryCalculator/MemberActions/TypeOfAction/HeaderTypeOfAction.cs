using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class HeaderTypeOfAction
    {
        public static void ChooseAction(IMember header, int act)
        {
            switch (act)
            {
                case 1:
                    AddingMember.AddMember(header);
                    break;
                case 2:
                    ReadingAllReports.ReadAllReport();
                    break;
                case 3:
                    ReadingMemberReport.ReadMemberReport();
                    break;
                case 4:
                    AddingHoursForMember.AddHoursForMember(header);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверное действие. Нажмите enter, чтобы повторить попытку");
                    break;
            }
        }
    }
}
