using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class CalcSalary
    {
        public static void GetHoursOfMember(IMember member)
        {
            int sumHours = 0;

            foreach (var report in ReaderMembersAndReports.reportOfMembers)
            {
                string[] personRep = report.Trim().Split(new char[] { ',' });
                string dateOfPersonRep = personRep[0];
                DateTime datePerson = Convert.ToDateTime(dateOfPersonRep);
                DateTime datePlus = DatePeriod.StartDate;


                if (report.Contains(member.Name) && (datePerson >= datePlus && datePerson <= DatePeriod.FinishDate))
                {
                    while (datePlus <= DatePeriod.FinishDate)
                    {
                        if (report.Contains(dateOfPersonRep))
                        {
                            int hoursOfPersonRep = Convert.ToInt32(personRep[2]);

                            sumHours += hoursOfPersonRep;

                            break;
                        }
                    }
                }
            }

            member.Hours = sumHours;
        }

        public static void GetSalaryOfMember(IMember member)
        {
            int salaryPerHour, salaryTotal;
            GetHoursOfMember(member);
            

            switch (member.Post)
            {
                case "header":
                    {
                        salaryPerHour = 1250;
                        salaryTotal = member.Hours * salaryPerHour;
                        if (member.Hours > 160)
                        {
                            salaryTotal += (member.Hours - 160) * 1000;
                            member.Salary = salaryTotal;
                        }
                        else
                            member.Salary = salaryTotal;
                        break;
                    }
                case "employee":
                    {
                        salaryPerHour = 750;
                        salaryTotal = member.Hours * salaryPerHour;
                        if (member.Hours > 160)
                        {
                            salaryTotal += (member.Hours - 160) * 1500;
                            member.Salary = salaryTotal;
                        }
                        else
                            member.Salary = salaryTotal;
                        break;
                    }
                default:
                    {
                        salaryPerHour = 1000;
                        salaryTotal = member.Hours * salaryPerHour;
                        member.Salary = salaryTotal;
                        break;
                    }
            }
        }
    }
}
