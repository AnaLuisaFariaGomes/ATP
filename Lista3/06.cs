using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class _06
    {
        static void Main(string[] args)
        {
            double nota, soma = 0;
            int cont = 0;

            Console.WriteLine("ATENÇÃO! Para finalizar o programa digite um número negativo.");
            Console.WriteLine("Digite uma nota: ");
            nota = int.Parse(Console.ReadLine());

            while (nota >= 0)
            {
                soma += nota;
                cont++;

                Console.WriteLine("Digite uma nota: ");
                nota = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A média das notas é {soma/cont}");
        }
    }
}
