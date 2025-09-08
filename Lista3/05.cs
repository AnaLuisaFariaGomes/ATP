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
            int x, y;

            Console.WriteLine("ATENÇÃO! Para finalizar o programa deixe os valores de x E y em 0.");
            Console.WriteLine("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y: ");
            y = int.Parse(Console.ReadLine());

            while (x != 0 || y != 0)
            {
                if (x>=0 && y>=0)
                {
                    Console.WriteLine("1° quadrante");
                }
                else if (y>=0 && x<0)
                {
                    Console.WriteLine("2° quadrante");
                }
                else if (y < 0 && x < 0)
                {
                    Console.WriteLine("3° quadrante");
                }
                else
                {
                    Console.WriteLine("4° quadrante");
                }

                Console.WriteLine("Digite o valor de x: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de y: ");
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Saindo...");
        }
    }
}
