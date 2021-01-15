using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public interface IMemberMessage
    {
        void GreetMessage(IMember member);
        void EnterDateToAddHours();
        void EnterAmountOfHours();
        void EnterWhatYouDid();
    }
}
