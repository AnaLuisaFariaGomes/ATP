using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class _04
    {
        static void Main(string[] args)
        {
            int num, idade, cont1=0 ,cont2=0, cont3 = 0, cont4 = 0, cont5= 0, i;

            Console.WriteLine("Insira um número: ");
            num = int.Parse(Console.ReadLine());
            i = num;

            while (num > 0)
            {
                Console.WriteLine("Digite a idade:");
                idade = int.Parse(Console.ReadLine());

                if(idade >= 1 && idade <=15)
                {
                    cont1++;
                }
                else if(idade>=16 && idade <=30)
                {
                    cont2++;
                }
                else if (idade >= 31 && idade <= 45)
                {
                    cont3++;
                }
                else if (idade >= 46 && idade <= 60)
                {
                    cont4++;
                }
                else if (idade >= 61)
                {
                    cont5++;
                }
                else
                {
                    Console.WriteLine("Idade inválida");
                }
                num--;
            }

            Console.WriteLine($"{cont1} pessoas tem de 1 à 15 anos. Correspondendo a {((double)cont1/ i)*100.0}% da população");
            Console.WriteLine($"{cont2} pessoas tem de 16 à 30 anos. Correspondendo a {((double)cont2 / i) * 100.0}% da população");
            Console.WriteLine($"{cont3} pessoas tem de 31 à 45 anos. Correspondendo a {((double)cont3 / i) * 100.0}% da população");
            Console.WriteLine($"{cont4} pessoas tem de 46 à 60 anos. Correspondendo a {((double)cont4 / i) * 100.0}% da população");
            Console.WriteLine($"{cont5} pessoas tem mais de 60 anos. Correspondendo a {((double)cont5 / i) * 100.0}% da população");
        }
    }
}
