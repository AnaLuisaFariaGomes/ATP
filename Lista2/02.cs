using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class _02
    {
        static void Main(string[] args)
        {
            int idade1, idade2, idade3;
            Console.WriteLine("Escreva a idade 1:");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a idade 2:");
            idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a idade 3:");
            idade3 = int.Parse(Console.ReadLine());

            if (idade1 == idade2 && idade1 == idade3)
            {
                Console.WriteLine("As idades são todas iguais.");
            }
            else if (idade1 <= idade2 && idade1<= idade3 && idade2 > idade3)
            {
                Console.WriteLine($"Menor: {idade1}\nMaior {idade2}");
            }
            else if (idade1 <= idade2 && idade1 <= idade3 && idade2 < idade3)
            {
                Console.WriteLine($"Menor: {idade1}\nMaior {idade3}");
            }
            else if (idade2 <= idade1 && idade2 <= idade3 && idade1 > idade3)
            {
                Console.WriteLine($"Menor: {idade2}\nMaior {idade1}");
            }
            else if (idade2 <= idade1 && idade2 <= idade3 && idade1 < idade3)
            {
                Console.WriteLine($"Menor: {idade2}\nMaior {idade3}");
            }
            else if (idade3 <= idade1 && idade3 <= idade2 && idade1 < idade2)
            {
                Console.WriteLine($"Menor: {idade3}\nMaior {idade2}");
            }
            else
            {
                Console.WriteLine($"Menor: {idade3}\nMaior {idade1}");
            }
        }
    }
}
