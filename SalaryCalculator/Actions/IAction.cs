using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public interface IAction
    {
        void ChooseAction(IMember member, int act);
    }
}
