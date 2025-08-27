using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    internal class _14
    {
        static void Main(string[] args)
        {
            int ano;
            bool bissexto;

            Console.WriteLine("Digite um ano: ");
            ano = int.Parse(Console.ReadLine());

            bissexto = ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0) ? true : false;

            Console.WriteLine($"O ano {ano} é bissexto? {bissexto}");
        }
    }
}
