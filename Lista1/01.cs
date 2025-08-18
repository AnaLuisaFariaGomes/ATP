using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class _01
    {
        static void Main(string[] args)
        {
            double km, ms;

            Console.WriteLine("Digite a velocidade (em Km/h):");
            km = double.Parse(Console.ReadLine());

            ms = km/3.6;

            Console.WriteLine($"{km}km/h equivalem a {ms}m/s.");
            Console.WriteLine();

        }
    }
}
