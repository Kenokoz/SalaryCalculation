using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class AddingHoursForMember
    {
        public static void AddHoursForMember()
        {
            HeaderMessage.EnterNameOfMember();
            string name = ValidInputValue.GetName();

            foreach (var memb in ReaderMembersAndReports.members)
            {
                if (memb.Name == name)
                {
                    StandardMessage.EnterDateToAddHours();
                    DateTime enterDate = ValidInputValue.GetDate();
                    ReportWriter.Date = enterDate.ToShortDateString();

                    StandardMessage.EnterAmountOfHours();
                    ReportWriter.Hours = ValidInputValue.GetHours();

                    HeaderMessage.EnterWhatMemberDid();
                    ReportWriter.Doing = Console.ReadLine();

                    ReportWriter.WriteHoursOfMember(name, memb.Post);
                    return;
                }
            }

            ErrorMessage.MemberIsNotExists();
            AddHoursForMember();
        }
    }
}
