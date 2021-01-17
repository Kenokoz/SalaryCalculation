using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class Continue
    {
        public static void AskToContinue(IMember member)
        {
            StandardMessage.Continue();
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "y":
                    {
                        if (member.Post == "header")
                        {
                            HeaderTypeOfAction.ChooseAction(member);
                        }
                        else
                        {
                            TypeOfAction.ChooseAction(member);
                        }
                        break;
                    }
                case "n":
                    Environment.Exit(0);
                    break;
                default:
                    ErrorMessage.InputAnswerIsNotCorrect();
                    AskToContinue(member);
                    break;
            }
        }
    }
}
