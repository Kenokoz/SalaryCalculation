using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryProject.Employees
{
    class Freelancer : Header
    {
        public Freelancer(string name, string post) : base(name, post) { }

        public new void Greet()
        {
            Console.WriteLine($"Здравствуйте, {name}!");
            Console.WriteLine($"Ваша роль: {post}");
            Console.WriteLine("Выберите желаемое действие:");
            Console.WriteLine("(1). Добавить часы.");
            Console.WriteLine("(2). Просмотреть отчет и зарплату.");
            Console.WriteLine("(3). Выход из программы");

            int act = int.Parse(Console.ReadLine());

            switch (act)
            {
                case 1:
                    Actions.AddHoursEmployee(name, post, Actions.PathFreelancers);
                    Continue();
                    break;
                case 2:
                    Actions.ReadReportEmp(name, Actions.PathFreelancers);
                    Continue();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверное действие.");
                    break;
            }
        }
    }
}
