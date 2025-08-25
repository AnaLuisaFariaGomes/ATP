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
            double litros,litrosMil, taxaAgua, taxaEsgoto, fatura;

            Console.WriteLine("Insia a quantidade de litros: ");
            litros = double.Parse(Console.ReadLine());

            litrosMil = litros / 1000;

            if (litrosMil < 0)
            {
                Console.WriteLine("O valor de litros inserido é inválido, tente novamente.");
            }
            else if (litrosMil >= 0 && litrosMil <= 75 )
            {
                taxaAgua = 305.55 + litrosMil * 2.11;
                taxaEsgoto = 226.05 + litrosMil * 1.56;
                fatura = taxaEsgoto + taxaAgua;
                Console.WriteLine($"O valor da fatura final é R${Math.Ceiling(fatura * 100) / 100}");
            }
            else if (litrosMil > 75 &&  litrosMil <= 150)
            {
                taxaAgua = 305.55 + 75 * 2.11;
                taxaEsgoto = 226.05 + 75 * 1.56;
                taxaAgua += (litrosMil - 75) * 4.496;
                taxaEsgoto += (litrosMil - 75) * 3.327;
                fatura = taxaEsgoto + taxaAgua;
                Console.WriteLine($"O valor da fatura final é R${Math.Ceiling(fatura * 100) / 100}");
            }
            else if (litrosMil > 150 && litrosMil <= 225)
            {
                taxaAgua = 305.55 + 75 * 2.11;
                taxaEsgoto = 226.05 + 75 * 1.56;
                taxaAgua += 75 * 4.496;
                taxaEsgoto += 75 * 3.327;
                taxaAgua += (litrosMil - 150) * 6.968;
                taxaEsgoto += (litrosMil - 150) * 5.156;
                fatura = taxaEsgoto + taxaAgua;
                Console.WriteLine($"O valor da fatura final é R${Math.Ceiling(fatura * 100) / 100}");
            }
            else
            {
                taxaAgua = 305.55 + 75 * 2.11;
                taxaEsgoto = 226.05 + 75 * 1.56;
                taxaAgua += 75 * 4.496;
                taxaEsgoto += 75 * 3.327;
                taxaAgua += 75 * 6.968;
                taxaEsgoto += 75 * 5.156;
                taxaAgua += (litrosMil - 225) * 9.514;
                taxaEsgoto += (litrosMil - 225) * 7.039;
                fatura = taxaEsgoto + taxaAgua;
                Console.WriteLine($"O valor da fatura final é R${Math.Ceiling(fatura*100)/100}");
            }
        }
    }
}
