using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Program
    {
        static void PesoAnimais(string caminho)
        {
            string linha;
            double menorPeso = int.MaxValue, maiorPeso = int.MinValue;
            int cont = 0;
            double soma = 0;

            try
            {
                StreamReader arq = new StreamReader(caminho, Encoding.UTF8);

                linha = arq.ReadLine();

                while (linha != null)
                {
                    string[] info = linha.Split(';');
                    int peso = int.Parse(info[3]);
                    if (peso < menorPeso)
                    {
                        menorPeso = peso;
                    }else if (peso > maiorPeso)
                    {
                        maiorPeso = peso;
                    }
                    soma += peso;
                    cont++;

                    linha = arq.ReadLine();
                }
                arq.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.WriteLine($"Menor peso: {menorPeso:F2}kg");
            Console.WriteLine($"Maior peso: {maiorPeso:F2}kg");
            Console.WriteLine($"Peso médio: {(soma / cont):F2}kg");

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //string caminho = @"C:\Users\analu\OneDrive\Documentos\PUC Minas\1° Semestre\ATP\Lista10\arquivo-01.txt";
            Console.WriteLine("Digite o caminho para o arquivo: ");
            string caminho = Console.ReadLine();

            PesoAnimais(caminho);
        }
    }
}
