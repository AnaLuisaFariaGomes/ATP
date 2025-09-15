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
            int n;
            double s = 1;

            Console.WriteLine("Digite o valor de n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= n; i++)
            {
                int fat = 1;
                for (int j = 1; j <= i; j++)
                {
                    fat *= j;
                }

                s += 1.0/fat;
            }
            Console.WriteLine($"S = {s:F2}");
        }
    }
}
