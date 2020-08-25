using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor M(Linhas) e um N(Colunas): ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Digite um número para consultar: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Posição: " + i + "," + j + ":");
                        if (j > 0) // Se o j(numero da coluna atual) for maior do que 0, existe objetos na esquerda
                        {
                            Console.WriteLine("Esquerda: " + mat[i, (j - 1)]);
                        }
                        if (j < n - 1) //se o j for menor que n - 1 (numero total de colunas) 
                        {
                            Console.WriteLine("Direita: " + mat[i, (j + 1)]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[(i - 1), j]);
                        }
                        if (i < m -1)
                        {
                            Console.WriteLine("Abaixo: " + mat[(i + 1), j]);
                        }
                    }
                }
            }
        }
    }
}
