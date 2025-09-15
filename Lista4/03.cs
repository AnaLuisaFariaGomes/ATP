using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class _03
    {
        static void Main(string[] args)
        {
            double preco, quant, maior, menor, soma=0, pagar;

            Console.WriteLine("Digite o preço do kWh (em R$): ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos kWh são consumidos por mês ");
            quant = double.Parse(Console.ReadLine());
            maior = quant;
            menor = quant;

            for (int i=1; i <= 49;  i++)
            {
                pagar = preco * quant;
                Console.WriteLine($"O valor a pagar pelo consumidor é R$: {pagar:F2}");

                soma += quant;
                if (maior < quant)
                {
                    maior = quant;
                }
                if (menor > quant)
                {
                    menor = quant;
                }

                Console.WriteLine("Digite o preço do kWh (em R$): ");
                preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos kWh são consumidos por mês ");
                quant = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Maior consumo: {maior:F2}kWh");
            Console.WriteLine($"Menor consumo: {menor:F2}kWh");
            Console.WriteLine($"Consumo médio = {(soma/50):F2}kWh");
        }
    }
}
