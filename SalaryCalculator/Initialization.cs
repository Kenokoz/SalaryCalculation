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
            string inputName = CorrectName.GetName();

            ;
            foreach (var person in MembersInCompany.members)
            {
                DataOfMember.GetDataOfMember(person);
                if (DataOfMember.Name == inputName)
                {
                    // Вызов приветствия
                    switch (DataOfMember.Post)
                    {
                        case "header":
                            {
                                Header header = new Header {Name = DataOfMember.Name, Post = DataOfMember.Post};
                                header.ShowMessage.GreetMessage(header);
                                break;
                            }
                        case "employee":
                            {
                                Employee employee = new Employee { Name = DataOfMember.Name, Post = DataOfMember.Post};
                                employee.ShowMessage.GreetMessage(employee);
                                break;
                            }
                        case "freelancer":
                            {
                                Freelancer freelancer = new Freelancer { Name = DataOfMember.Name, Post = DataOfMember.Post};
                                freelancer.ShowMessage.GreetMessage(freelancer);
                                break;
                            }
                    }
                    return;
                }
            }

            StandardMessage.MemberIsNotExists();
            InitializeMember();
        }
    }
}
