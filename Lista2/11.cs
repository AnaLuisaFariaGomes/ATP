using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class _11
    {
        static void Main(string[] args)
        {
            int opcao;
            double valor, resul;

            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1. Converter de centímetros para metros");
            Console.WriteLine("2. Converter de metros para centímetros");
            Console.WriteLine("3. Converter de milímetros para metros");
            Console.WriteLine("4. Converter de metros para milímetros\n");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número para conversão: ");
            valor = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    resul = valor / 100;
                    Console.WriteLine($"{valor}cm é igual a {resul}m");
                    break;
                case 2:
                    resul = valor * 100;
                    Console.WriteLine($"{valor}m é igual a {resul}cm");
                    break;
                case 3:
                    resul = valor / 1000;
                    Console.WriteLine($"{valor}mm é igual a {resul}m");
                    break;
                case 4:
                    resul = valor * 1000;
                    Console.WriteLine($"{valor}m é igual a {resul}mm");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
