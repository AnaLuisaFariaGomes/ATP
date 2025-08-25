using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class _03
    {
        static void Main(string[] args)
        {
            int anosHabilitacao, idade;
            char tipoCarteira;

            Console.WriteLine("Insira sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu tipo de cateira (B ou C): ");
            tipoCarteira = char.Parse(Console.ReadLine());
            Console.WriteLine("Insira há quantos anos possui esse tipo de habilitação: ");
            anosHabilitacao = int.Parse(Console.ReadLine());

            if (tipoCarteira == 'D' || tipoCarteira == 'd')
            {
                Console.WriteLine("Você já possui carteira tipo D.");
            }
            else if (tipoCarteira == 'B' || tipoCarteira == 'b')
            {
                if (idade >= 21 && anosHabilitacao >= 2)
                {
                    Console.WriteLine("Possui os requisitos necessários para adiquirir habilitação D.");
                }
                else if (idade >= 21 && anosHabilitacao < 2)
                {
                    Console.WriteLine("Não possui o tempo de habilitação necessário para adiquirir habilitação D.");
                }
                else if (idade < 21 && anosHabilitacao >= 2)
                {
                    Console.WriteLine("Não possui idade necessária para adiquirir habilitação D.");
                }
                else if (idade < 21 && anosHabilitacao < 2)
                {
                    Console.WriteLine("Não possui idade nem tempo de habilitação necessários para adiquirir habilitação D.");
                }
            }
            else if (tipoCarteira == 'C' || tipoCarteira == 'c')
            {
                if (idade >= 21 && anosHabilitacao >= 1)
                {
                    Console.WriteLine("Possui os requisitos necessários para adiquirir habilitação D.");
                }
                else if (idade >= 21 && anosHabilitacao < 1)
                {
                    Console.WriteLine("Não possui o tempo de habilitação necessário para adiquirir habilitação D.");
                }
                else if (idade < 21 && anosHabilitacao >= 1)
                {
                    Console.WriteLine("Não possui idade necessária para adiquirir habilitação D.");
                }
                else if (idade < 21 && anosHabilitacao < 1)
                {
                    Console.WriteLine("Não possui idade nem tempo de habilitação necessários para adiquirir habilitação D.");
                }
            }
            else
            {
                Console.WriteLine("O tipo de habilitação inserido é inválido, tente novamente.");
            }
        }
    }
}
