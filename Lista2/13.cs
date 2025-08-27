using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class _13
    {
        static void Main(string[] args)
        {
            char sexo;
            double altura, pesoIdeal;

            Console.WriteLine("Digite sua altura (em metros): ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu sexo (M/F): ");
            sexo = char.Parse(Console.ReadLine().ToUpper());

            pesoIdeal = (sexo == 'M') ? (72.7 * altura) - 58 : (62.1 * altura) - 44.7;
            Console.WriteLine($"Seu peso ideal é: {pesoIdeal:F2}kg");
        }
    }
}
