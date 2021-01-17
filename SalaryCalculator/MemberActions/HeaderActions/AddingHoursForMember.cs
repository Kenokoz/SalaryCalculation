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

            StandardMessage.EnterDateToAddHours();
            DateTime enterDate = DateTime.Parse(Console.ReadLine());
            MemberInformation.Date = enterDate.ToShortDateString();

            StandardMessage.EnterAmountOfHours();
            MemberInformation.Hours = int.Parse(Console.ReadLine());

            HeaderMessage.EnterWhatMemberDid();
            MemberInformation.Doing = Console.ReadLine();

            foreach (var memb in MembersInCompany.members)
            {
                if (memb.Name == name)
                {
                    MemberInformation.WriteHoursOfMember(name, memb.Post);
                    break;
                }
            }

        }
    }
}
