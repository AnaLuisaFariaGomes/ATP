using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class _02
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Escreva o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            if (x % 2 != 0 || y % 2 != 0)
            {
                if (x <= y)
                {
                    while (x <=y)
                    {
                        if ((x % 2) != 0)
                        {
                            Console.WriteLine(x);
                        }
                        x++;
                    }
                }
                else {
                    Console.WriteLine("Erro! Valores inválidos.");
                }
            }
            else
            {
                Console.WriteLine("Erro! Valores inválidos.");
            }
        }
    }
}
