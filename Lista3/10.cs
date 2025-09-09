using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class _10
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int s = 0, num = 480;

            while (cont < 30)
            {
                if (num % 2 == 0)
                {
                    s += num;
                }
                else
                {
                    s -= num;
                }
                num -= 5;
                cont++;
            }

            Console.WriteLine("O valor final da série para 30 termos é: "+ s);
        }
    }
}
