using ExecicioArquivos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                //sourceFolderPath Caminho da Pasta ORIGEM
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); 
                //targetFolderPath Caminho da Pasta DESTINO = Caminho da Origem + incremento da subpasta out
                string targetFolderPath = sourceFolderPath + @"\out";
                //targetFilePath novo Arquivo da Pasta DESTINO = Nome Caminho da Pasta Destino + o incremento de seu nome(\summary.csv)
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath); //Cria a nova pasta out (Se ela nao existir, caso exista o metodo não cria)

                using (StreamWriter sw = File.AppendText(targetFilePath))  //Escreve no novo Arquivo da pasta out criado pelo File.AppendText
                {
                    foreach (string line in lines) //Ira ler uma linha de cada vez, e escrever da maneira nova no arquivo dentro da out
                    {

                        string[] fields = line.Split(','); //Separa cada atributo separado por virgula em uma localização do vetor
                        string name = fields[0]; //Posição 0 = recebeu o nome
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture); // 1 = recebeu preço
                        int quantity = int.Parse(fields[2]); // 2 = recebeu quantidade

                        Product prod = new Product(name, price, quantity); //Instanciou o novo produto

                        //Escreve uma uma linha com o Nome e o Valor * Quantidade do produto
                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
