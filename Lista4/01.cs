using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class _01
    {
        static void Main(string[] args)
        {
            double valeA, valeT, m, total;
            /*valeA = Vale Alimentaçãoo; valeT = vale Transporte; m = metros produzidos*/

            for (int pedreiro = 1; pedreiro <= 25; pedreiro++)
            {
                Console.WriteLine("Digite o valor do vale alimentação (em R$): ");
                valeA = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do vale transporte (em R$): ");
                valeT = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos metros quadrados o pedreiro prodziu: ");
                m = double.Parse(Console.ReadLine());

                total = 0;

                for (int i = 1; i <= m; i++)
                {
                    if (i >= 0 && i < 10)
                    {
                        total += 10.00;
                    }
                    else if (i >= 10 && i < 20)
                    {
                        total += 11.50;
                    }
                    else if (i >= 20)
                    {
                        total += 13.00;
                    }
                }
                total += valeA + 2 * valeT;
                Console.WriteLine("O valor a ser pago para esse pedreiro é R$" + total);
            }
        }
    }
}
