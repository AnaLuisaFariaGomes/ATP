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
            double reais, cotacaoDolar, convercao;

            //dados solicitados ao user
            Console.WriteLine("Digite a quantidade em reais: ");
            reais = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cotação do dólar: ");
            cotacaoDolar = double.Parse(Console.ReadLine());

            //questão
            convercao = reais / cotacaoDolar;
            Console.WriteLine("O valor em reais equivale a $" + convercao.ToString("N2") + " doláres.");
        }
    }
}
