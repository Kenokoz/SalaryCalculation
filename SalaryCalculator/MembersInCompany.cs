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
        List<IMemberModel> members = new List<IMemberModel>();

        public void AddMembers()
        {
            using (StreamReader sr = new StreamReader(Paths.toMembers))
            {
                string member;
                while ((member = sr.ReadLine()) != null)
                {
                    string[] namePost = member.Split(new char[] { ',' });
                    if (member.Contains("header"))
                    {
                        members.Add(new HeaderModel { Name = namePost[0], Post = namePost[1] });
                    }
                    else if (member.Contains("employee"))
                    {
                        members.Add(new EmployeeModel { Name = namePost[0], Post = namePost[1] });
                    }
                    else if (member.Contains("freelancer"))
                    {
                        members.Add(new FreelancerModel { Name = namePost[0], Post = namePost[1] });
                    }
                }
            }

            members.
            //foreach (var member in memberData)
            //{
                
            //}
        }


        //public static List<string> members = GetMembers();

        //public static List<string> headersData = new List<string>();
        //public static List<string> employeesData = new List<string>();
        //public static List<string> freelancersData = new List<string>();

        //public static void GetEmployeesFromMembers()
        //{
        //    foreach (var member in members)
        //    {
        //        if (member.Contains("header"))
        //        {
        //            headers.Add(member);
        //        }
        //        else if (member.Contains("employee"))
        //        {
        //            employees.Add(member);
        //        }
        //        else if (member.Contains("freelancer"))
        //        {
        //            freelancers.Add(member);
        //        }
        //    }
        //}

        //private static List<string> GetMembers()
        //{
        //    List<string> members = new List<string>();

        //    using (StreamReader sr = new StreamReader(Paths.toMembers))
        //    {
        //        string emp;
        //        while ((emp = sr.ReadLine()) != null) 
        //        {
        //            members.Add(emp);
        //        }
        //    }

        //    return members;
        //}
    }
}
