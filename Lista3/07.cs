using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class _07
    {
        static void Main(string[] args)
        {
            int op, mesesTrabalho;
            double salario, novoSalario, ferias, decimoTerceiro;

            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1 - Novo Salário;");
            Console.WriteLine("2 - Férias;");
            Console.WriteLine("3 - Décimo terceiro;");
            Console.WriteLine("4 - Sair");

            Console.WriteLine("Digite qual operação quer realizar: ");
            op = int.Parse(Console.ReadLine());

            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o valor do salário: ");
                        salario = double.Parse(Console.ReadLine());
                        if (salario <= 999.99)
                        {
                            novoSalario = salario * 1.15;
                        }
                        else if (salario <= 2000.00 && salario >= 1000.00)
                        {
                            novoSalario = salario * 1.10;
                        }
                        else
                        {
                            novoSalario = salario * 1.05;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor do salário: ");
                        salario = double.Parse(Console.ReadLine());
                        ferias = salario + (salario / 3);
                        break;
                    case 3:
                        Console.WriteLine("Digite o valor do salário: ");
                        salario = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade de meses que trabalha na empresa: ");
                        mesesTrabalho = int.Parse(Console.ReadLine());
                        if (mesesTrabalho <= 12 && mesesTrabalho >= 1)
                        {
                            decimoTerceiro = (salario * mesesTrabalho) / 12;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade inválida");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
