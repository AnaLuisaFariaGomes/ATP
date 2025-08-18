using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class _10
    {
        static void Main(string[] args)
        {
            int numOriginal, novaUnidade, novaCentena, novaDezena;

            Console.WriteLine("Digite um número inteiro de 3 dígitos: ");
            numOriginal = int.Parse(Console.ReadLine());

            novaCentena = numOriginal % 10;
            Console.Write("Numero novo: " + novaCentena);

            novaDezena = (numOriginal / 10) % 10;
            Console.Write(novaDezena);

            novaUnidade = numOriginal / 100;
            Console.WriteLine(novaUnidade);
        }
    }
}
