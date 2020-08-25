using System;
using System.IO;
using System.Collections.Generic;
namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int vote = int.Parse(line[1]);
                        //Se na Dictionary ja contem esta chave nome, realiza a soma dos votos que possui com o novo
                        if (dic.ContainsKey(name))                        {

                            dic[name] += vote;
                        }
                        else
                        {
                            dic[name] = vote;
                        }
                    }
                    foreach (KeyValuePair<string, int> item in dic)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}