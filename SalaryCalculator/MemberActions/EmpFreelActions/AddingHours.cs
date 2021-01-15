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
                member.ShowMessage.EnterDateToAddHours();
                DateTime enterDate = DateTime.Parse(Console.ReadLine());
                Information.Date = enterDate.ToShortDateString();

                if (member.Post == "freelancer")
                {

                    isDateCorrect = DateTime.Now.AddDays(-3) < enterDate && enterDate < DateTime.Now;

                    if (!isDateCorrect)
                    {
                        Console.WriteLine("Вы не можете добавлять часы раньше, чем за 2 дня");
                        continue;
                    }
                }
                else
                {
                    isDateCorrect = true;
                }
            }

            member.ShowMessage.EnterAmountOfHours();
            Information.Hours = int.Parse(Console.ReadLine());

            member.ShowMessage.EnterWhatYouDid();
            Information.Doing = Console.ReadLine();

            Information.WriteHoursOfMember(member.Name, member.Post);
        }
    }
}
