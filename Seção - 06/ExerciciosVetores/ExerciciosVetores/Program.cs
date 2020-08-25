using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Estudante[] estudante = new Estudante[10]; //Estancia o número maximo de Estudantes
            if (n <= 10) //N (Numero de quartos) não pode ser maior que 10
            {
                for (int i = 1; i <= n; i++) //foi utilizado indicina com inicio 1 para aproveitar a variavel de acordo o numero de quartos
                {
                    Console.WriteLine("Aluguel #" + i + ": ");
                    Console.Write("Nome: ");
                    String nome = Console.ReadLine();
                    Console.Write("Email: ");
                    String email = Console.ReadLine();
                    Console.Write("Quarto: ");
                    int quarto = int.Parse(Console.ReadLine());
                    estudante[quarto] = new Estudante(nome, email); //dentro de estudante com o numero de tal [quarto] será guardado 1 Estudante(nome, email)

                }
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Quartos oculpados: ");
                for (int i = 0; i < 10; i++)
                {
                    if (estudante[i] != null) //estudante da posição 0 até a 9 não pode ser nula
                    {
                        
                        Console.WriteLine(i + ": " + estudante[i]); //se o estudante da posição [i] que for = a do posição [quarto] ira printar
                    }
                }

            }
        }
    }
}
