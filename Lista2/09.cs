using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class _09
    {
        static void Main(string[] args)
        {
            int dia;

            Console.WriteLine("Digite um dia: ");
            dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    break;
            }
        }
    }
}
