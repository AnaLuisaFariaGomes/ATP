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
            int idade;

            Console.WriteLine("Insia a idade do nadador: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 5)
            {
                Console.WriteLine("O nadador não tem categoria.");
            }
            else if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Infantil A");
            }
            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Infantil B");
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Juvenil A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Juvenil B");
            }
            else
            {
                Console.WriteLine("Sênior");
            }
        }
    }
}
