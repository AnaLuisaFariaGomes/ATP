using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1
{
    internal class _02
    {
        static void Main(string[] args)
        {
            double lado, p, a, d; //perimetro = p; area = a; diagonal = d

            Console.Write("Digite o valor do lado do quadrado: ");
            lado = double.Parse(Console.ReadLine());

            p = lado * 4;
            Console.WriteLine($"O perímetro desse quarado de lado {lado} é {p}");

            a = Math.Pow(lado,2);
            Console.WriteLine($"A área desse quarado de lado {lado} é {a}");

            d = lado*Math.Sqrt(2);
            Console.WriteLine($"A diagonal desse quarado de lado {lado} é {d}");
        }
    }
}