using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class Action : IAction
    {
        public void ChooseAction(IMember member, int act)
        {
            switch (act)
            {
                case 1:
                    AddHoursForEmployee(member);
                    break;
                case 2:
                    //Actions.ReadReportEmp(name, Actions.PathEmpSalary);
                    //Continue();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверное действие.");
                    break;
            }
        }

        public void AddHoursForEmployee(IMember member)
        {
            member.ShowMessage.EnterDateToAddHours();
            Information.Date = DateTime.Parse(Console.ReadLine()).ToShortDateString();

            member.ShowMessage.EnterAmountOfHours();
            Information.Hours = int.Parse(Console.ReadLine());

            member.ShowMessage.EnterWhatDid();
            Information.Doing = Console.ReadLine();

            // TODO: Name
            Information.WriteHoursOfMember(member.Name);
        }
    }
}
