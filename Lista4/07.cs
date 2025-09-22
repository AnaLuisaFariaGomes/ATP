using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class _07
    {
        static void Main(string[] args)
        {
            string continuar;

            do
            {
                Console.Clear();
                Console.Write("Digite o salário bruto mensal (R$):");
                double salario = double.Parse(Console.ReadLine());
                double desconto = 0;

                if (salario <= 1412.00)
                {
                    desconto = salario * 0.075;
                }
                else
                {
                    desconto += 1412.00 * 0.075;
                    if (salario <= 2666.68)
                    {
                        desconto += (salario - 1412.00) * 0.09;
                    }
                    else
                    {
                        desconto += (2666.68 - 1412.00) * 0.09;
                        if (salario <= 4000.03)
                        {
                            desconto += (salario - 2666.68) * 0.12;
                        }
                        else
                        {
                            desconto += (4000.03 - 2666.68) * 0.12;
                            if (salario <= 7786.02)
                            {
                                desconto += (salario - 4000.03) * 0.14;
                            }
                            else
                            {
                                desconto += (7786.02 - 4000.03) * 0.14;
                            }
                        }
                    }
                }

                Console.WriteLine($"\nDesconto do INSS: R${Math.Round(desconto, 2)}");

                Console.WriteLine("Deseja continuar? (S ou N)");
                continuar = Console.ReadLine().ToUpper();

            } while (continuar != "N");

        }
    }
}
