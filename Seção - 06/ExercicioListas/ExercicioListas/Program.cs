using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Quantos funcionarios deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ": ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, nome, salario));
                Console.WriteLine("");

            }
            Console.WriteLine("-----------------------------------");
            Console.Write("Digite o Id do funcionario que deseja Aumentar o Salario: ");
            int funcId = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == funcId);
            if (emp != null)
            {
                Console.Write("Inserir porcertagem para aumento: ");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentarSalario(perc);
            }
            else
            {
                Console.WriteLine("Id não existente");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
