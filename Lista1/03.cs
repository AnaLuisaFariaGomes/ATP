using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class _03
    {
        static void Main(string[] args)
        {
            double b, h, p, a, d; //base=b; altura=h; perimetro=p; area=a; diagonal=d

            //dados solicitados ao user
            Console.Write("Digite o valor da base do retângulo: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do retângulo: ");
            h = double.Parse(Console.ReadLine());

            //calculos
            p = 2 * (b + h);
            Console.WriteLine($"O perímetro desse retângulo é {p}");

            a = b * h;
            Console.WriteLine($"A área desse retângulo é {a}");

            double potencias = Math.Pow(b, 2) + Math.Pow(h, 2);
            d = Math.Sqrt(potencias);
            Console.WriteLine($"A diagonal desse retângulo é {d}");
        }
    }
    
}
