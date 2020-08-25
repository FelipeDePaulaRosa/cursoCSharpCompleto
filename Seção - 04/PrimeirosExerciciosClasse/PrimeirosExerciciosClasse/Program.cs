using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosExerciciosClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Maria";
            p1.idade = 17;

            Pessoa p2 = new Pessoa();
            p2.nome = "João";
            p2.idade = 16;

            if(p1.idade > p2.idade)
            {
                Console.WriteLine(p1.nome + " é mais velh@");
            }
            else
            {
                Console.WriteLine(p1.nome + " é mais velh@");
            }
        }
    }
}
