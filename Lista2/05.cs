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
            int w, x, y, z;
            double g, p, h, a;

            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1 - Média Geométrica");
            Console.WriteLine("1 - Média Ponderada");
            Console.WriteLine("1 - Média Harmônica");
            Console.WriteLine("1 - Média Aritmética");
            Console.WriteLine("Selecione uma operação de média para ser realizada: ");
            w = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de y:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de z:");
            z = int.Parse(Console.ReadLine());

            if (w <=0 || w > 4)
            {
                Console.WriteLine("Número de operação inválido. Tente novamente.");
            }
            else if (w == 1)
            {
                g = Math.Sqrt(x*y*z);
                Console.WriteLine(g);
            }
            else if (w == 2)
            {
                p = (x + 2 * y + 3 * z) / 6;
                Console.WriteLine(p);
            }
            else if (w == 3)
            {
                h = 1 / (1/x + 1/y + 1/z);
                Console.WriteLine(h);
            }
            else
            {
                 a = (x + y + z) / 3;
                Console.WriteLine(a);
            }
        }
    }
}
