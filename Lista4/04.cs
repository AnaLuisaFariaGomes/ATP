using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class _04
    {
        static void Main(string[] args)
        {
            double temp, maior = int.MinValue, menor = int.MaxValue;
            int diaMaior=1, diaMenor=1;

            for (int i = 0; i<=31; i++)
            {
                Console.WriteLine($"Digite a temperatura média do dia {i} de abril:");
                temp = double.Parse(Console.ReadLine());

                if (temp > maior)
                {
                    maior = temp;
                    diaMaior = i;
                }
                if (temp < menor)
                {
                    menor = temp;
                    diaMenor = i;
                }
            }
            Console.WriteLine($"A maior temperatura do mês de Abril foi {maior}° e ocorreu no dia {diaMaior}");
            Console.WriteLine($"A menor temperatura do mês de Abril foi {menor}° e ocorreu no dia {diaMenor}");
        }
    }
}
