using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class _07
    {
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1 - Novo Salário;");
            Console.WriteLine("2 -  Férias;");
            Console.WriteLine("3 - Décimo terceiro;");
            Console.WriteLine("4 - Sair");

            Console.WriteLine("Digite qual operação quer realizar: ");
            op = int.Parse(Console.ReadLine());
        }
    }
}
