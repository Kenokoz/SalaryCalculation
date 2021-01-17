using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class Initialization
    {
        public static void InitializeMember()
        {
            StandardMessage.EnterName();
            string inputName = ValidInputValue.GetName();
                       
            foreach (var member in ReaderMembersAndReports.members)
            {
                //DataOfMember.GetDataOfMember(person);
                if (member.Name == inputName)
                {
                    IMember person = CreateModel(member);
                    Console.Clear();
                    if (person.Post == "header")
                    {
                        HeaderTypeOfAction.ChooseAction(person);
                    }
                    else
                    {
                        TypeOfAction.ChooseAction(person);
                    }

                    return;
                }
            }

            ErrorMessage.MemberIsNotExists();
            InitializeMember();
        }

        private static IMember CreateModel(IMember member)
        {
            switch (member.Post)
            {
                case "header":
                    return new HeaderModel { Name = member.Name, Post = member.Post };
                case "employee":
                    return new EmployeeModel { Name = member.Name, Post = member.Post };
                default:
                    return new FreelancerModel { Name = member.Name, Post = member.Post };
            }
        }
    }
}
