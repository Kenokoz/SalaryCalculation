using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class MembersInCompany
    {
        public static List<string> members = GetMembers();

        private static List<string> GetMembers()
        {
            List<string> members = new List<string>();

            using (StreamReader sr = new StreamReader(Path.toMembers))
            {
                string emp;
                while ((emp = sr.ReadLine()) != null)
                {
                    members.Add(emp);
                }
            }

            return members;
        }
    }
}
