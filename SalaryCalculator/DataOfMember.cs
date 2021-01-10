using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class DataOfMember
    {
        public static string Name { get; private set; }
        public static string Post { get; private set; }
        
        public static void GetDataOfMember(string member)
        {
            string[] personData = member.Split(new char[] { ',' });
            Name = personData[0];
            Post = personData[1];
        }
    }
}
