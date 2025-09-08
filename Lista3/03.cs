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
            int dia = 1, diaMaior=0;
            double pluv, soma=0.0, maior=0.00;

            while (dia <=31)
            {
                Console.WriteLine($"Escreva o  índice pluviométrico de {dia} de janeiro:");
                pluv = double.Parse( Console.ReadLine());

                soma += pluv;
                if ( pluv > maior )
                {
                    maior = pluv;
                    diaMaior = dia;
                }
                dia++;
            }

            Console.WriteLine($"O  índice pluviométrico médio desse mês foi {soma/31}");
            Console.WriteLine($"O  índice pluviométrico máximo desse mês foi {maior} e ocorreu no dia {diaMaior}");
        }
    }
}
