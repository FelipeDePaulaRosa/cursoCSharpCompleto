using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimeirosExerciciosClasse_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Digite o Nome do funcionario: ");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Digite o Salario do funcionario: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o Nome do funcionario 2: ");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Digite o Salario do funcionario 2: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) / 2;
            Console.WriteLine("Média: " + media);
        }
    }
}
