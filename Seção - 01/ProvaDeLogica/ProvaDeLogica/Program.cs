using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDeLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1.1:
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago

            Console.WriteLine("Digite o Código da Peça 1: ");
            int peça1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Número de Peças (Quantidade): ");
            int quantidade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor unitário: ");
            double valor1 = double.Parse(Console.ReadLine());

            double soma = quantidade1 * valor1;

            Console.WriteLine("Digite o Código da Peça 2: ");
            int peça2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Número de Peças (Quantidade): ");

            int quantidade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor unitário: ");

            double valor2 = double.Parse(Console.ReadLine());

            double soma2 = quantidade2 * valor2;

            double total = soma + soma2;

            Console.WriteLine("O valor a ser pago e: " + total);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Exercício 1.2:
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            //casas decimais conforme exemplos.
            //Fórmula: Area = PI.raio²
            //Considere o valor de π = 3.14159*/

            //Console.WriteLine("Digite o valor do Raio do circulo: ");
            //double raio = double.Parse(Console.ReadLine());
            //double area = Math.PI * Math.Pow(raio, 2);
            //Console.WriteLine("A Área do seu circulo é: " + area.ToString("F2"));

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Exercício 2.1:
            //Com base na tabela de preços ao lado, faça
            //um programa que leia o código de um item e a
            //quantidade deste item. A seguir, calcule e
            //mostre o valor da conta a pagar.


            //double valor = 0;

            //Console.WriteLine("CÓDIGO - ESPECIFICAÇÃO");
            //Console.WriteLine("1 -      CACHORRO QUENTE");
            //Console.WriteLine("2 -      X-SALADA");
            //Console.WriteLine("3 -      X-BACON");
            //Console.WriteLine("4 -      TORRADA SIMPLES");
            //Console.WriteLine("5 -      REFRIGERANTE");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Digite o código do produto que deseja: ");
            //int codigo = int.Parse(Console.ReadLine());

            //if (codigo == 1)
            //{
            //    valor = 4.00;
            //}

            //else if (codigo == 2)
            //{
            //    valor = 4.50;
            //}

            //else if (codigo == 3)
            //{
            //    valor = 5.00;
            //}

            //else if (codigo == 4)
            //{
            //    valor = 2.00;
            //}

            //else
            //{
            //    valor = 1.50;
            //}

            //Console.WriteLine("Digite a quantidade: ");
            //int qtd = int.Parse(Console.ReadLine());

            //double total = valor * qtd;

            //Console.WriteLine("Total: " + total);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Exercício 2.2:
            //Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau(ax² +bx + c = 0)
            //Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara(veja
            //abaixo).Se a equação não possuir raízes(o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
            //negativo), mostrar uma mensagem "Impossivel calcular".
            //Fórmula: x = -b ± √∆ / 2 * a onde: ∆= b² − 4 * ac

            //Console.WriteLine("Digite abaixo os valores de A, B e C respectivamente: ");
            //double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double xPositivo = 0;
            //double xNegativo = 0;
            //double delta = 0;
            //if (a > 0)
            //{
            //    delta = Math.Pow(b, 2) - 4 * a * c;

            //    if (delta >= 0)
            //    {
            //        xPositivo = (-b + Math.Sqrt(delta)) / (2 * a);
            //        xNegativo = (-b - Math.Sqrt(delta)) / (2 * a);
            //        Console.WriteLine("Valor Positivo: " + xPositivo);
            //        Console.WriteLine("Valor Negativo: " + xNegativo);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Impossivel calcular");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Impossivel calcular");
            //}

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////Exercício 3.1:
            ////Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            ////incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            ////impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            //Console.WriteLine("Digite a senha: ");
            //int senha = int.Parse(Console.ReadLine());
            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha Invalida!");
            //    Console.WriteLine("");
            //    Console.WriteLine("Digite a senha: ");
            //    senha = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Acesso Permitido");


            //Exercício 3.2:
            //Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            //Console.WriteLine("Digite a quantidade de números: ");
            //int n = int.Parse(Console.ReadLine());
            //int aux= 0;
            //int In = 0;
            //int Out = 0;

            //Console.WriteLine("Digite os números a serem analisados");
            //Console.WriteLine("//////////////////////////////////////");
            //for (int i = 0; i < n; i++)
            //{
            //   aux = int.Parse(Console.ReadLine());
            //   if(aux >=10 && aux <= 20)
            //    {
            //        In++;
            //    }
            //    else
            //    {
            //        Out++;
            //    }

            //}
            //Console.WriteLine("In: " + In);
            //Console.WriteLine("Out: " + Out);


        }
    }


}