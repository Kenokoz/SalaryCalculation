using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryProject
{
    class Header
    {
        protected string name, post;

        public Header(string name, string post)
        {
            this.name = name;
            this.post = post;
        }

        public void Greet()
        {
            Console.Clear();
            Console.WriteLine($"Здравствуйте, {name}!");
            Console.WriteLine($"Ваша роль: {post}");
            Console.WriteLine("Выберите желаемое действие:");
            Console.WriteLine("(1). Добавить сотрудника");
            Console.WriteLine("(2). Просмотреть отчет по всем сотрудникам");
            Console.WriteLine("(3). Просмотреть отчет по конкретному сотруднику");
            Console.WriteLine("(4). Добавить часы работы");
            Console.WriteLine("(5). Выход из программы");

            int act = int.Parse(Console.ReadLine());

            switch (act)
            {
                case 1:
                    Actions.AddEmployee();
                    string choice = Console.ReadLine();
                    Console.Clear();
                    Actions.ContinueOrExite(choice);
                    break;
                case 2:
                    Actions.ReadReport();
                    Continue();
                    break;
                case 3:
                    Actions.ReadEmployee();
                    Continue();
                    break;
                case 4:
                    Actions.AddHours();
                    Continue();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверное действие. Нажмите enter, чтобы повторить попытку");
                    Greet();
                    break;
            }
        }

        public void Continue()
        {
            Console.WriteLine("Действие успешно выполнено. Хотите продолжить? 'Y' (ДА), 'N' (НЕТ)");
            string choice = Console.ReadLine();
            Console.Clear();
            Actions.ContinueOrExite(choice);
        }
    }
}
