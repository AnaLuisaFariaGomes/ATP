using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void NomePorIdade (string caminho)
        {
            string linha;

            try
            {
                StreamReader arq = new StreamReader(caminho, Encoding.UTF8);

                linha = arq.ReadLine();

                while (linha != null)
                {
                    string[] info = linha.Split(';');
                    int idadeMax = int.Parse(info[4]);
                    if (idadeMax >= 10 && idadeMax <= 16)
                    {
                        Console.WriteLine(info[0]);
                    }
                        linha = arq.ReadLine();

                }

                arq.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //string caminho = @"C:\Users\analu\OneDrive\Documentos\PUC Minas\1° Semestre\ATP\Lista10\arquivo-01.txt";
            Console.WriteLine("Digite o caminho para o arquivo: ");
            string caminho = Console.ReadLine();

            NomePorIdade(caminho);
        }
    }
}
