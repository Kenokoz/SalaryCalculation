using SalaryProject.Employees;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryProject
{
    class Actions : Initialization
    {
        protected static int hours;

        protected static string pathEmployees = @"C:\Users\Кирилл\Desktop\Project\Список сотрудников.txt";
        protected static string pathEmpSalary = @"C:\Users\Кирилл\Desktop\Project\Список отработанных часов сотрудников на зарплате.txt";
        protected static string pathHeaders = @"C:\Users\Кирилл\Desktop\Project\Список отработанных часов руководителей.txt";
        protected static string pathFreelancers = @"C:\Users\Кирилл\Desktop\Project\Список отработанных часов внештатных сотрудников.txt";

        static public string PathEmployees { get { return pathEmployees; } }
        static public string PathEmpSalary { get { return pathEmpSalary; } }
        static public string PathHeaders { get { return pathHeaders; } }
        static public string PathFreelancers { get { return pathFreelancers; } }

        static public int Hours { get { return hours; } set { hours = value; } }

        static public void AddEmployee()
        {
            string employee = null;
            string post = null;
            string nameInFile = File.ReadAllText(pathEmployees);

            using (StreamWriter sw = new StreamWriter(pathEmployees, true))
            {
                Console.WriteLine("Введите имя сотрудника:");

                employee = ToUpperName();
                if (employee != null && !nameInFile.Contains(employee))
                {
                    Console.WriteLine("Введите должность сотрудника ('header', 'employee', 'freelancer'):");
                    post = Console.ReadLine();

                    if (post != null && (post == "header" || post == "employee" || post == "freelancer"))
                    {
                        sw.Write(employee + ",");
                        sw.WriteLine(post);
                        Console.WriteLine("Сотрудник успешно добавлен. Хотите продолжить? 'Y' (ДА), 'N' (НЕТ)");
                    }
                    else
                    {
                        Console.WriteLine("Такой должности не существует. Повторите попытку.");
                        sw.Close();
                        AddEmployee();
                    }
                }
                else if (nameInFile.Contains(employee))
                {
                    Console.WriteLine("Такое имя уже записано!");
                }
            }
        }

        static public void ReadReport()
        {
            try
            {
                WriteDate(out DateTime dateStart, out DateTime dateFinish);
                Console.WriteLine($"Отчет за период с {dateStart.ToShortDateString()} по {dateFinish.ToShortDateString()}");

                Read(pathHeaders, dateStart, dateFinish);
                Read(pathEmpSalary, dateStart, dateFinish);
                Read(pathFreelancers, dateStart, dateFinish);
                Console.WriteLine(new string('-', 20));

                Console.WriteLine("Желаете посмотреть еще один отчет? Нажмите 'Y' (ДА) для продолжения. 'N' (НЕТ) для выхода на главный экран программы.");
                string check = char.Parse(Console.ReadLine()).ToString();
                Enter(check);
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный ввод даты! Попробуйте еще раз.");
                WriteDate(out DateTime dateStart, out DateTime dateFinish);
            }
            
        }
        static public void ReadReportEmp(string name, string path)
        {
            try
            {
                WriteDate(out DateTime dateStart, out DateTime dateFinish);

                ReadEmoloyeeOut(path, dateStart, dateFinish, name);
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный ввод даты! Попробуйте еще раз.");
                ReadEmployee();
            }
        }
        static public void Read(string path, DateTime dateStart, DateTime dateFinish)
        {
            List<string> names = new List<string>();
            using (StreamReader sr = new StreamReader(pathEmployees))
            {
                string firstWord;
                while ((firstWord = sr.ReadLine()) != null)
                {
                    string[] firstWords = firstWord.Split(new char[] { ',' });
                    names.Add(firstWords[0]);
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                bool toSee = false;

                using (StreamReader sr = new StreamReader(path))
                {
                    toSee = SearchName(names[i], path);
                    string employee;

                    while ((employee = sr.ReadLine()) != null && toSee)
                    {
                        if (employee.Contains(names[i]) && toSee)
                        {
                            Console.WriteLine(new string('-', 20));
                            hours = CalcHours(path, dateStart, dateFinish);
                            Console.WriteLine($"{names[i]} отработал {hours} часов и заработал за период {CalcSalary(path, dateStart, dateFinish, hours)} руб");
                            break;
                        }
                    }
                }
            }
        }
        static public void ReadEmployee()
        {
            Console.WriteLine("Введите имя сотрудника:");
            string name = ToUpperName();
            if (SearchName(name, PathEmployees))
            {
                try
                {
                    WriteDate(out DateTime dateStart, out DateTime dateFinish);

                    using (StreamReader sr = new StreamReader(pathEmployees))
                    {
                        string employee;
                        while ((employee = sr.ReadLine()) != null)
                        {
                            if (employee.Contains(name) && employee.Contains("header"))
                            {
                                ReadEmoloyeeOut(pathHeaders, dateStart, dateFinish, name);
                            }
                            else if (employee.Contains(name) && employee.Contains("employee"))
                            {
                                ReadEmoloyeeOut(pathEmpSalary, dateStart, dateFinish, name);
                            }
                            else if (employee.Contains(name) && employee.Contains("freelancer"))
                            {
                                ReadEmoloyeeOut(pathFreelancers, dateStart, dateFinish, name);
                            }

                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод даты! Попробуйте еще раз.");
                    ReadEmployee();
                }
                
            }
            else
            {
                Console.WriteLine("Сотрудник не найден! Попробуйте еще раз.");
                ReadEmployee();
            }
        }
        static public void ReadEmoloyeeOut(string path, DateTime dateStart, DateTime dateFinish, string name)
        {
            hours = CalcHours(path, dateStart, dateFinish);
            Console.WriteLine($"Отчет по сотруднику: {name} за период с {dateStart.ToShortDateString()} по {dateFinish.ToShortDateString()}");
            SearchDate(dateStart, dateFinish, name, path);
            Console.WriteLine($"Итого: {hours} часов, заработано: {CalcSalary(path, dateStart, dateFinish, hours)} руб");
        }

        static public void AddHoursEmployee(string name, string post, string path)
        {
            Console.WriteLine("Введите дату, в которую нужно добавить часы:");
            string date = DateTime.Parse(Console.ReadLine()).ToShortDateString();
            if (Convert.ToDateTime(date) > DateTime.Now.AddDays(2) && post == "freelancer")
            {
                Console.WriteLine("Вы не можете добавить в эту дату, так как добавление времени возможно не ранее, чем за два дня от текущего времени!");
                AddHoursEmployee(name, post, path);
            }
            Console.WriteLine("Введите количество часов:");
            hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите что делали:");
            string doing = Console.ReadLine();

            using (StreamWriter sr = new StreamWriter(path, true))
            {
                sr.WriteLine($"{date}, {name}, {hours}, {doing}");
            }
        }
        static public void AddHours()
        {
            Console.WriteLine("Введите имя сотрудника:");
            string name = ToUpperName();

            Console.WriteLine("Введите дату, в которую нужно добавить часы:");
            string date = DateTime.Parse(Console.ReadLine()).ToShortDateString();
           
            Console.WriteLine("Введите количество часов:");
            hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите что делал сотрудник:");
            string doing = Console.ReadLine();

            using (StreamReader sr = new StreamReader(pathEmployees))
            {
                string position;
                while ((position = sr.ReadLine()) != null)
                {
                    if (position.Contains($"{name},header"))
                    {
                        using (StreamWriter sw = new StreamWriter(pathHeaders, true))
                        {
                            sw.WriteLine($"{date}, {name}, {hours}, {doing}");
                        }
                    }
                    else if (position.Contains($"{name},employee"))
                    {
                        using (StreamWriter sw = new StreamWriter(pathEmpSalary, true))
                        {
                            sw.WriteLine($"{date}, {name}, {hours}, {doing}");
                        }
                    }
                    else if (position.Contains($"{name},freelancer"))
                    {
                        using (StreamWriter sw = new StreamWriter(pathFreelancers, true))
                        {
                            sw.WriteLine($"{date}, {name}, {hours}, {doing}");
                        }
                    }
                }
            }


        }

        static public int CalcHours(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string word;
                int sumHours = 0;
                while ((word = sr.ReadLine()) != null)
                {
                    string[] hours = word.Trim().Split(new char[] { ',' });

                    int hour = Convert.ToInt32(hours[2]);

                    sumHours += hour;
                }
                return sumHours;
            }
        }
        static public int CalcHours(string path, DateTime dateFirst, DateTime dateSecond)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string word;
                int sumHours = 0;
                while ((word = sr.ReadLine()) != null)
                {
                    int i = 1;
                    for (DateTime datePlus = dateFirst; datePlus <= dateSecond; datePlus = dateFirst.AddDays(i++))
                    {

                        if (word.Contains(Convert.ToString(datePlus).Substring(0, 10)))
                        {
                            string[] hours = word.Trim().Split(new char[] { ',' });

                            int hour = Convert.ToInt32(hours[2]);

                            sumHours += hour;
                        }
                    }
                }
                return sumHours;
            }
        }

        static public int CalcSalary(string path, DateTime dateFirst, DateTime dateSecond, int hours)
        {
            int salaryPerHour, salaryTotal;

            if (path == pathHeaders)
            {
                salaryPerHour = 1250;
                salaryTotal = hours * salaryPerHour;
                if (hours > 160)
                {
                    salaryTotal += (hours - 160) * 1000;
                    return salaryTotal;
                }
                else
                    return salaryTotal;
            }
            else if (path == pathEmpSalary)
            {
                salaryPerHour = 750;
                salaryTotal = hours * salaryPerHour;
                if (hours > 160)
                {
                    salaryTotal += (hours - 160) * 1500;
                    return salaryTotal;
                }
                else
                    return salaryTotal;
            }
            else
            {
                salaryPerHour = 1000;
                salaryTotal = hours * salaryPerHour;
                return salaryTotal;
            }
        }

        static public void SearchDate(DateTime dateFirst, DateTime dateSecond, string name, string path)
        {
            int i = 1;
            for (DateTime datePlus = dateFirst; datePlus <= dateSecond; datePlus = dateFirst.AddDays(i++))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string rep;
                    while ((rep = sr.ReadLine()) != null)
                    {
                        if (rep.Contains(Convert.ToString(datePlus).Substring(0, 10)))
                        {
                            Console.WriteLine(rep.Replace(name + ", ",  ""));
                        }
                    }
                }
            }
        }
        static public bool SearchName(string name, string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string rep = sr.ReadToEnd();
                if (rep.Contains(name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static public bool SearchNameForInitialize(string name, string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string rep;
                while ((rep = sr.ReadLine()) != null)
                {
                    string[] firstWord = rep.Split(new char[] { ',' });
                    if (firstWord[0] == name)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        static public void Enter(string check)
        {
            switch (check.ToLower())
            {
                case "y":
                    {
                        ReadReport();
                        break;
                    }
                case "n":
                    {
                        Header header = new Header(Initialization.name, Initialization.post);
                        header.Greet();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Некорректный ввод! Попробуйте еще раз.");
                        check = char.Parse(Console.ReadLine()).ToString();
                        Enter(check);
                        break;
                    }
            }
        }
        static public void ContinueOrExite(string act)
        {
            switch (act.ToLower())
            {
                case "y":
                    {
                        if (Initialization.post == "header")
                        {
                            Header header = new Header(Initialization.name, Initialization.post);
                            header.Greet();
                            break;
                        }
                        else if (Initialization.post == "employee")
                        {
                            Employee employee = new Employee(Initialization.name, Initialization.post);
                            employee.Greet();
                            break;
                        }
                        else
                        {
                            Freelancer freelancer = new Freelancer(Initialization.name, Initialization.post);
                            freelancer.Greet();
                            break;
                        }
                    }
                case "n":
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Некорректный ввод! Попробуйте еще раз.");
                        act = Console.ReadLine();
                        ContinueOrExite(act);
                        break;
                    }
            }
        }
        static public void WriteDate(out DateTime dateStart, out DateTime dateFinish)
        {
            Console.WriteLine("Введите с какого числа:");
            dateStart = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите по какое число:");
            dateFinish = DateTime.Parse(Console.ReadLine());

        }
        static public string ToUpperName()
        {
            string name = Console.ReadLine().Trim();
            string result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            return result;
        }
    }
}
