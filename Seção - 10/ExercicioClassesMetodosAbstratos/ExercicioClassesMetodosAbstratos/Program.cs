using ExercicioClassesMetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClassesMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char choice = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (choice == 'i' || choice == 'I')
                {                   
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                    
                    list.Add(new PessoaFisica(name, anualIncome, healthExpenditures));
                }
                else if (choice == 'c' || choice == 'C'){                  
                    Console.Write("Number of Employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());                    
                    list.Add(new PessoaJuridica(name, anualIncome, numberEmployees));
                }
                
            }
            Console.WriteLine("");
            Console.WriteLine("TAXES PAID: ");
            double sum = 0;
            foreach (Pessoa p in list)
            {
                double tax = p.Tax();
                Console.WriteLine(p.Name + ": $ " + tax);
                sum += tax;
            }
            Console.WriteLine("");
            Console.WriteLine("TOTAL TAXES: " + sum);
            
        }
    }
}
