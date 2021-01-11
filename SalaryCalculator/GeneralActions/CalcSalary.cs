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

            foreach (var person in MembersInCompany.reportOfMembers)
            {
                string[] personRep = person.Trim().Split(new char[] { ',' });
                string dateOfPersonRep = personRep[0];
                DateTime datePlus = DatePeriod.StartDate;


                if (person.Contains(member.Name) && Convert.ToDateTime(dateOfPersonRep) >= datePlus)
                {
                    while (datePlus <= DatePeriod.FinishDate)
                    {
                        if (person.Contains(dateOfPersonRep))
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
