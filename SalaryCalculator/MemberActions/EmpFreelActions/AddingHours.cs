using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class AddingHours
    {
        public static void AddHours(IMember member)
        {
            bool isDateCorrect = false;

            while (!isDateCorrect)
            {
                StandardMessage.EnterDateToAddHours();
                DateTime enterDate = DateTime.Parse(Console.ReadLine());
                MemberInformation.Date = enterDate.ToShortDateString();

                if (member.Post == "freelancer")
                {

                    isDateCorrect = DateTime.Now.AddDays(-3) < enterDate && enterDate < DateTime.Now;

                    if (!isDateCorrect)
                    {
                        ErrorMessage.CanNotAddHoursBeforeTwoDays();
                        continue;
                    }
                }
                else
                {
                    isDateCorrect = true;
                }
            }

            StandardMessage.EnterAmountOfHours();
            MemberInformation.Hours = int.Parse(Console.ReadLine());

            StandardMessage.EnterWhatYouDid();
            MemberInformation.Doing = Console.ReadLine();

            MemberInformation.WriteHoursOfMember(member.Name, member.Post);
        }
    }
}
