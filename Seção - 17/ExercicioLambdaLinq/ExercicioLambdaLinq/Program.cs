using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using ExercicioLambdaLinq.Entities;
using System.Globalization;

namespace ExercicioLambdaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }
            Console.Write("Enter salary: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Email of people whose salary is more than " + amount + ": ");

            var alphabetic = employees.Where(e => e.Salary > amount).OrderBy(e => e.Email).Select(e => e.Email);
            foreach (string dados in alphabetic)
            {
                Console.WriteLine(dados);
            }
            var sum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum);
        }
    }
}
