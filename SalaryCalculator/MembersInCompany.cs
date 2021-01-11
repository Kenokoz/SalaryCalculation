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
        public static List<string> reportOfMembers = GetReportOfMembers();

        private static List<string> GetMembers()
        {
            List<string> members = new List<string>();

            using (StreamReader sr = new StreamReader(Path.toMembers))
            {
                string memb;
                while ((memb = sr.ReadLine()) != null)
                {
                    members.Add(memb);
                }
            }

            return members;
        }

        private static List<string> GetReportOfMembers()
        {
            List<string> reportOfMembers = new List<string>();
            List<string> pathsToReports = new List<string> 
            { 
                Path.toHoursOfHeaders, 
                Path.toHoursOfEmployees,
                Path.toHoursOfFreelancers
            };

            foreach (var path in pathsToReports)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string memb;
                    while ((memb = sr.ReadLine()) != null)
                    {
                        reportOfMembers.Add(memb);
                    }
                }
            }

            return reportOfMembers;
        }
    }
}
