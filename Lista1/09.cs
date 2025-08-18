using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class _09
    {
        static void Main(string[] args)
        {
            double graus, radiano;

            Console.WriteLine("Digite o ângulo em graus: ");
            graus = double.Parse(Console.ReadLine());

            radiano = graus * (Math.PI / 180);
            Console.WriteLine($"O angulo em radianos é {radiano}.");
        }
    }
}
