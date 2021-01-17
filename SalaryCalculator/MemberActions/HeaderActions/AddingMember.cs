﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class AddingMember
    {
        static public void AddMember(IMember header)
        {
            // header.ShowHeaderMessage.EnterNameOfMember();
            string nameOfMember = ValidInputValue.GetName();
            bool isMemberExist = false;

            foreach (var member in MembersInCompany.members)
            {
                isMemberExist = member.Name.Contains(nameOfMember);
            }

            if (!isMemberExist)
            {
                HeaderMessage.EnterPostOfMember();
                string postOfMember = ValidInputValue.GetPost();

                if (postOfMember == "header" || postOfMember == "employee" || postOfMember == "freelancer")
                {
                    using (StreamWriter sw = new StreamWriter(Path.toMembers, true))
                    {
                        sw.WriteLine($"{nameOfMember},{postOfMember}");
                    }
                    Console.WriteLine("Сотрудник успешно добавлен. Хотите продолжить? 'Y' (ДА), 'N' (НЕТ)");
                }
                else
                {
                    ErrorMessage.PostNotExist();
                }

            }
            else
            {
                ErrorMessage.MemberExists();
            }
        }
    }
}
