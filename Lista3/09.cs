using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    internal class _09
    {
        static void Main(string[] args)
        {
            int num, anterior=1, atual = 0, fib;
            
            Console.Write("Insira quantos números da sequencia de Fibonacci: ");
            num = int.Parse(Console.ReadLine());
            
            while (num > 0) {
                fib = anterior + atual;
                Console.WriteLine(fib);
                anterior = atual;
                atual = fib;
                
                num--;
            }
        }
    }
}
