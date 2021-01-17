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
        public static List<IMember> members = GetMembersList();
        public static List<string> reportOfMembers = GetReportOfMembers();

        private static List<IMember> GetMembersList()
        {
            List<IMember> members = new List<IMember>();

            using (StreamReader sr = new StreamReader(Path.toMembers))
            {
                string member;
                while ((member = sr.ReadLine()) != null)
                {
                    string[] dataOfMember = member.Split(new char[] { ',' });
                    switch (dataOfMember[1])
                    {
                        case "header":
                            members.Add(new Header { Name = dataOfMember[0], Post = dataOfMember[1] });
                            break;
                        case "employee":
                            members.Add(new Employee { Name = dataOfMember[0], Post = dataOfMember[1] });
                            break;
                        case "freelancer":
                            members.Add(new Freelancer { Name = dataOfMember[0], Post = dataOfMember[1] });
                            break;
                    }
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
