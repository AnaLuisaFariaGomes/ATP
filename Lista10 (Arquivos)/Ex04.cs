using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Program
    {
        static void NomeporPeso(string caminho1, string caminho2)
        {
            string linha1;
            string linha2;

            try
            {
                StreamReader arq2 = new StreamReader(caminho2, Encoding.UTF8);
                linha2 = arq2.ReadLine();

                while (linha2 != null)
                {
                    string[] info2 = linha2.Split(';');
                    int pesoMax = int.Parse(info2[1]);
                    int pesoMin = int.Parse(info2[0]);

                    StreamReader arq1 = new StreamReader(caminho1, Encoding.UTF8);
                    linha1 = arq1.ReadLine();

                    Console.WriteLine($"Linha {linha2}: ");

                    while (linha1 != null)
                    {
                        string[] info1 = linha1.Split(';');
                        int peso = int.Parse(info1[3]);

                        if (peso >= pesoMin && peso <= pesoMax)
                        {
                            Console.WriteLine(info1[0]);
                        }
                        linha1 = arq1.ReadLine();
                    }

                    arq1.Close();
                    linha2 = arq2.ReadLine();
                    Console.WriteLine();
                }
                arq2.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //string caminho1 = @"C:\Users\analu\OneDrive\Documentos\PUC Minas\1° Semestre\ATP\Lista10\arquivo-01.txt";
            //string caminho2 = @"C:\Users\analu\OneDrive\Documentos\PUC Minas\1° Semestre\ATP\Lista10\arquivo-02.txt";
            Console.WriteLine("Digite o caminho para o arquivo 1: ");
            string caminho1 = Console.ReadLine();
            Console.WriteLine("Digite o caminho para o arquivo 2: ");
            string caminho2 = Console.ReadLine();

            NomeporPeso(caminho1, caminho2);
        }
    }
}
