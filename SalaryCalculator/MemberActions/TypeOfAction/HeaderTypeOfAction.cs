using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class HeaderTypeOfAction
    {
        public static void ChooseAction(IMember header)
        {
            Console.Clear();

            HeaderMessage.GreetMessageForHeader(header);
            int act = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (act)
            {
                case 1:
                    AddingMember.AddMember();
                    Continue.AskToContinue(header);
                    break;
                case 2:
                    ReadingAllReports.ReadAllReport();
                    Continue.AskToContinue(header);
                    break;
                case 3:
                    ReadingMemberReport.ReadMemberReport();
                    Continue.AskToContinue(header);
                    break;
                case 4:
                    AddingHoursForMember.AddHoursForMember();
                    Continue.AskToContinue(header);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    ErrorMessage.WrongAction();
                    break;
            }
        }
    }
}
