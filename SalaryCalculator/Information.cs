﻿using System;
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


        public static void WriteHoursOfMember(string name)
        {
            using (StreamWriter sr = new StreamWriter(Path.toHoursOfEmployees, true))
            {
                sr.WriteLine($"{Date}, {name}, {Hours}, {Doing}");
            }
        }
    }
}