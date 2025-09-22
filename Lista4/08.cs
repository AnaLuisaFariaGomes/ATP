using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class _08
    {
        static void Main(string[] args)
        {
            int raiz, cont = 0, impar = 1;

            Console.WriteLine("Digite o número da raiz: ");
            raiz = int.Parse(Console.ReadLine());

            do
            {
                raiz -= impar;
                impar += 2;
                cont++;
            } while (raiz > 0);

            if (raiz == 0)
            {
                Console.WriteLine($"A raiz quadrada é {cont}");
            }
            else
            {
                Console.WriteLine("Não existe raiz quadrada exata");
            }
        }
    }
}
