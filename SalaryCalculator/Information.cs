using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class Information
    {
        public static string Date { get; set; }
        public static int Hours { get; set; }
        public static string Doing { get; set; }


        public static void WriteHoursOfMember(string name, string post)
        {
            string path = null;

            switch (post)
            {
                case "header":
                    path = Path.toHoursOfHeaders;
                    break;
                case "employee":
                    path = Path.toHoursOfEmployees;
                    break;
                case "freelancer":
                    path = Path.toHoursOfFreelancers;
                    break;
            }
            using (StreamWriter sr = new StreamWriter(path, true))
            {
                sr.WriteLine($"{Date},{name},{Hours},{Doing}");
            }
        }
    }
}
