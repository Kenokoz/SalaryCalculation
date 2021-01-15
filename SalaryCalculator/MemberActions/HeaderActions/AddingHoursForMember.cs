using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class AddingHoursForMember
    {
        public static void AddHoursForMember(IMember member)
        {
            Console.WriteLine("Введите имя сотрудника:");
            string name = ValidInputValue.GetName();

            member.ShowMessage.EnterDateToAddHours();
            DateTime enterDate = DateTime.Parse(Console.ReadLine());
            Information.Date = enterDate.ToShortDateString();

            member.ShowMessage.EnterAmountOfHours();
            Information.Hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите что делал сотрудник:");
            Information.Doing = Console.ReadLine();

            foreach (var memb in MembersInCompany.members)
            {
                if (memb.Name == name)
                {
                    Information.WriteHoursOfMember(name, memb.Post);
                    break;
                }
            }

        }
    }
}
