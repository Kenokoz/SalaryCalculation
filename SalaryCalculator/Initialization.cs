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

            ;
            foreach (var member in MembersInCompany.members)
            {
                //DataOfMember.GetDataOfMember(person);
                if (member.Name == inputName)
                {
                    // Вызов приветствия
                    switch (member.Post)
                    {
                        case "header":
                            {
                                Header header = new Header {Name = member.Name, Post = member.Post};
                                header.ShowMessage.GreetMessage(header);

                                int act = int.Parse(Console.ReadLine());
                                HeaderTypeOfAction.ChooseAction(header,act);
                                break;
                            }
                        case "employee":
                            {
                                Employee employee = new Employee { Name = member.Name, Post = member.Post};
                                employee.ShowMessage.GreetMessage(employee);

                                int act = int.Parse(Console.ReadLine());
                                TypeOfAction.ChooseAction(employee, act);
                                break;
                            }
                        case "freelancer":
                            {
                                Freelancer freelancer = new Freelancer { Name = member.Name, Post = member.Post};
                                freelancer.ShowMessage.GreetMessage(freelancer);

                                int act = int.Parse(Console.ReadLine());
                                TypeOfAction.ChooseAction(freelancer, act);
                                break;
                            }
                    }
                    return;
                }
            }

            ErrorMessage.MemberIsNotExists();
            InitializeMember();
        }
    }
}
