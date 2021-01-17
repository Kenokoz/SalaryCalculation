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
                       
            foreach (var member in MembersInCompany.members)
            {
                //DataOfMember.GetDataOfMember(person);
                if (member.Name == inputName)
                {
                    IMember person = CreateModel(member);
                    
                    if (person.Post == "header")
                    {
                        HeaderMessage.GreetMessageForHeader(person);
                        HeaderTypeOfAction.ChooseAction(person);
                    }
                    else
                    {
                        StandardMessage.GreetMessageForEmpAndFreelan(person);
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
                    return new Header { Name = member.Name, Post = member.Post };
                case "employee":
                    return new Employee { Name = member.Name, Post = member.Post };
                default:
                    return new Freelancer { Name = member.Name, Post = member.Post };
            }
        }
    }
}
