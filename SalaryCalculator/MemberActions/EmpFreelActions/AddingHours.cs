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
                DateTime enterDate = ValidInputValue.GetDate();
                ReportWriter.Date = enterDate.ToShortDateString();

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
            ReportWriter.Hours = ValidInputValue.GetHours();

            StandardMessage.EnterWhatYouDid();
            ReportWriter.Doing = Console.ReadLine();

            ReportWriter.WriteHoursOfMember(member.Name, member.Post);

        }
    }
}
