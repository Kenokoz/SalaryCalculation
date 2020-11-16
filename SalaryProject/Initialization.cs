using SalaryProject.Employees;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryProject
{
    class Initialization
    {
        protected static string name, post;
        
        public string Name { get { return name; } set { name = value; } }
        public string Post { get { return post; } set { post = value; } }

        public void Initialize()
        {
            Console.WriteLine("Введите ваше имя:");
            name = Actions.ToUpperName();
            if (Actions.SearchNameForInitialize(name, Actions.PathEmployees))
            {
                string employees;

                using (StreamReader sr = new StreamReader(Actions.PathEmployees))
                {

                    while ((employees = sr.ReadLine()) != null)
                    {
                        string[] firstWord = employees.Split(new char[] { ',' });
                        if (name == firstWord[0])
                        {
                            if (employees.Contains(name) && employees.Contains(post = "header"))
                            {
                                sr.Close();
                                Header header = new Header(name, post);
                                header.Greet();
                                break;
                            }
                            else if (employees.Contains(name) && employees.Contains(post = "employee"))
                            {
                                sr.Close();
                                Employee employee = new Employee(name, post);
                                employee.Greet();
                                break;
                            }
                            else if (employees.Contains(name) && employees.Contains(post = "freelancer"))
                            {
                                sr.Close();
                                Freelancer freelancer = new Freelancer(name, post);
                                freelancer.Greet();
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Такого сотрудника не существует. Повторите попытку.");
                Initialize();
            }
        }
    }
}
