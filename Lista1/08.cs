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
            double despesas, percentualGorjeta, gorjeta, total;

            //dados solicitados ao user
            Console.WriteLine("Digite as despesas realizadas no restaurante: ");
            despesas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos % gostaria de dar como gorjeta? ");
            percentualGorjeta = double.Parse(Console.ReadLine());

            //questão
            gorjeta = (percentualGorjeta * despesas) / 100;
            total = despesas + gorjeta;
            Console.WriteLine($"O valor da gorgeta deve ser dê R${gorjeta}.\nO valor total da conta é R${total}.");
        }
    }
}
