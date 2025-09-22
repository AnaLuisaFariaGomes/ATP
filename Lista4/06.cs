using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class _06
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1 - Converter de Celsius para Fahrenheit");
                Console.WriteLine("2 - Converter de Celsius para Kelvin");
                Console.WriteLine("3 - Converter de Fahrenheit para Celsius");
                Console.WriteLine("4 - Converter de Fahrenheit para Kelvin");
                Console.WriteLine("5 - Converter de Kelvin para Celsius");
                Console.WriteLine("6 - Converter de Kelvin para Fahrenheit");
                Console.WriteLine("7 - Sair");
                Console.WriteLine("\nDigite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                double temperatura, resultado;

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a temperatura em Celsius: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura * 9 / 5) + 32;
                        Console.WriteLine($"{temperatura}°C = {resultado}°F");
                        break;

                    case 2:
                        Console.Write("Digite a temperatura em Celsius: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura + 273.15;
                        Console.WriteLine($"{temperatura}°C = {resultado}°K");
                        break;

                    case 3:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura - 32) * 5 / 9;
                        Console.WriteLine($"{temperatura}°F = {resultado}°C");
                        break;

                    case 4:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura - 32) * 5 / 9 + 273.15;
                        Console.WriteLine($"{temperatura}°F = {resultado}°K");
                        break;

                    case 5:
                        Console.Write("Digite a temperatura em Kelvin: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura - 273.15;
                        Console.WriteLine($"{temperatura}°K = {resultado}°C");
                        break;

                    case 6:
                        Console.Write("Digite a temperatura em Kelvin: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura - 273.15) * 9 / 5 + 32;
                        Console.WriteLine($"{temperatura}°K = {resultado}°F");
                        break;

                    case 7:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 7);
        }
    }
}
