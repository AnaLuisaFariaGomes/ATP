using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class _05
    {
        static void Main(string[] args)
        {
            int eleitores, votosBrancos, votosNulos, votosValidos;

            Console.WriteLine("Digite o número de eleitores dessa cidade: ");
            eleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos em branco: ");
            votosBrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos nulos: ");
            votosNulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos válidos: ");
            votosValidos = int.Parse(Console.ReadLine());

            double percentualVotosBrancos = (100 * votosBrancos) / eleitores;
            Console.WriteLine($"{percentualVotosBrancos}% dos votos são votos em branco.");

            double percentualVotosNulos = (100 * votosNulos) / eleitores;
            Console.WriteLine($"{percentualVotosNulos}% dos votos são votos nulos.");

            double percentualVotosValidos = (100 * votosValidos) / eleitores;
            Console.WriteLine($"{percentualVotosValidos}% dos votos são votos válidos.");
        }
    }
}
