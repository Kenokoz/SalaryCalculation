using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class TypeOfAction
    {
        public static void ChooseAction(IMember member)
        {
            Console.Clear();

            StandardMessage.GreetMessageForEmpAndFreelan(member);
            int act = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (act)
            {
                case 1:
                    AddingHours.AddHours(member);
                    Continue.AskToContinue(member);
                    break;
                case 2:
                    ReadingReport.ReadReportAndSalary(member);
                    Continue.AskToContinue(member);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    ErrorMessage.WrongAction();
                    break;
            }
        }
    }
}
