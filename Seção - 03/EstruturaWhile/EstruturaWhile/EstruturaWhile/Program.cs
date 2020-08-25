using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1114/uri1114/Program.cs
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.
            //Console.WriteLine("Digite a senha: ");
            //int senha = int.Parse(Console.ReadLine());
            //while (senha != 2002)
            //{
            //Console.WriteLine("Senha Invalida!");
            //Console.WriteLine("");
            //Console.WriteLine("Digite a senha: ");
            //    senha = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Acesso Permitido");

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Exercício 02
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1115/uri1115/Program.cs
            //Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
            //cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            //menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).
            
            //int x = 1; 
            //int y = 1; 
            //while (x != 0 || y != 0)
            //{
            //    Console.WriteLine("Digite o valor de x, e y: ");
            //    x = int.Parse(Console.ReadLine());
            //    y = int.Parse(Console.ReadLine());  
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("segundo");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("terceiro");
            //    }
            //    else if (x > 0 && y < 0)
            //    {
            //        Console.WriteLine("quarto");
            //    }
            //    Console.WriteLine("-------------------------");
            //}         

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Exercício 03
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1134/uri1134/Program.cs
            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            //um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            //4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            //que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            //exemplo.

            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;
            //int escolha = 0;

            //while (escolha != 4)
            //{
            //    Console.WriteLine("Esolha sua opção: ");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("MUITO OBRIGADO");
            //    Console.WriteLine("1.Alcool: " + alcool);
            //    Console.WriteLine("2.Gasolina: " + gasolina);
            //    Console.WriteLine("3.Diesel: " + diesel);
            //    Console.WriteLine("4.Fim");
            //    escolha = int.Parse(Console.ReadLine());
            //    if (escolha == 1)
            //    {
            //        alcool++;
            //    }
            //    else if (escolha == 2)
            //    {
            //        gasolina++;
            //    }
            //    else if (escolha == 3)
            //    {
            //        diesel++;
            //    }
            //    Console.Clear();
            //}
        }
    }
}
