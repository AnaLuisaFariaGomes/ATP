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
            int n;

            Console.WriteLine("Insira um número: ");
            n = int.Parse(Console.ReadLine());

            if (n % 3 == 0 && n % 5== 0)
            {
                Console.WriteLine("O número é divisível por 3 e por 5.");
            }
            else
            {
                Console.WriteLine("O numéro não é divisível por 3 e por 5.");
            }
        }
    }
}
