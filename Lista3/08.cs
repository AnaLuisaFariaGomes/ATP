using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class _08
    {
        static void Main(string[] args)
        {
            char continuar;
            double salario, mediaSalario = 0, anosEstudo, mediaEstudo = 0, maiorSalario = double.MinValue;
            int contH = 0 /*quantidade de habitantes*/, contS = 0,/*quantidade de habitantes com salario até 5000*/ contE = 0 /*quantidade de habitantes com mais de 15 anos de estudo*/;

            Console.WriteLine("Deseja iniciar o programa (s/n) :");
            continuar = char.Parse(Console.ReadLine().ToUpper());

            while (continuar != 'N')
            {
                Console.WriteLine("Insira o salário do habitante: ");
                salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a quantidade de anos de estudo do habitante");
                anosEstudo = double.Parse(Console.ReadLine());

                contH++;
                mediaSalario += salario;
                mediaEstudo += anosEstudo;
                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }
                if (salario <= 5000)
                {
                    contS++;
                }
                if (anosEstudo >= 15)
                {
                    contE++;
                }

                Console.WriteLine("Deseja informar os dados de mais um habitante? (s/n)");
                continuar = char.Parse(Console.ReadLine().ToUpper());
            }

            Console.WriteLine($"A media do salário da população é de R${(mediaSalario/contH):F2}");
            Console.WriteLine($"A media de anos de estudo da população é de R${(mediaEstudo / contH):F2}");
            Console.WriteLine("O maior salário é R$" + maiorSalario);
            Console.WriteLine($"O percentual de habitantes cujo salário é inferior a R$5000 é {((double)contS / contH * 100):F2}%");
            Console.WriteLine($"O percentual de habitantes cujos anos de estudo é superior à 15 é {((double)contE / contH * 100):F2}%");


        }
    }
}
