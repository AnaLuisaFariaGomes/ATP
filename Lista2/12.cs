using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class _12
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Digite uma letra: ");
            letra = char.Parse(Console.ReadLine().ToUpper());

            switch (letra)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine($"{letra} é uma vogal.");
                    break;
                default:
                    Console.WriteLine($"{letra} é uma consoante.");
                    break;
            }
        }
    }
}
