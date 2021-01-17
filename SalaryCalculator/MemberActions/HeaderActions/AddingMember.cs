using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class AddingMember
    {
        static public void AddMember()
        {
            HeaderMessage.EnterNameOfMember();
            string nameOfMember = ValidInputValue.GetName();

            foreach (var member in ReaderMembersAndReports.members)
            {
                bool isMemberExist = member.Name.Contains(nameOfMember);
                if (isMemberExist)
                {
                    ErrorMessage.MemberIsWritten();
                    AddMember();
                }
            }

            HeaderMessage.EnterPostOfMember();
            string postOfMember = ValidInputValue.GetPost();

            if (postOfMember == "header" || postOfMember == "employee" || postOfMember == "freelancer")
            {
                using (StreamWriter sw = new StreamWriter(Path.toMembers, true))
                {
                    sw.WriteLine($"{nameOfMember},{postOfMember}");
                }
                HeaderMessage.MemberAdded();
            }
            else
            {
                ErrorMessage.PostNotExist();
            }

        }
    }
}
