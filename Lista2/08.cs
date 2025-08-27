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
            string empresa, cargo, nome;
            double salBruto, salLiq, desconto = 0;

            Console.Write("Digite o nome da empresa: ");
            empresa = Console.ReadLine();
            Console.Write("Digite o cargo do funcionário: ");
            cargo = Console.ReadLine();
            Console.Write("Digite o nome do funcionário: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do salário bruto: ");
            salBruto = Double.Parse(Console.ReadLine());
            salLiq = salBruto;

            if (salBruto >= 0 && salBruto <=1518.00)
            {
                desconto = salBruto * 0.075;
                salLiq = salBruto - desconto;
                Console.WriteLine($"Funcionário {nome}, cargo {cargo}\nSalário Bruto: {salBruto}\nDesconto: {desconto} \nSalário Líquido: {salLiq}");
            }
            else if (salBruto <= 2793.88 && salBruto >= 1518.01)
            {
                desconto = salBruto * 0.09;
                salLiq = salBruto - desconto;
                Console.WriteLine($"Funcionário {nome}, cargo {cargo}\nSalário Bruto: {salBruto}\nDesconto: {desconto} \nSalário Líquido: {salLiq}");
            }
            else if (salBruto >= 2793.89 && salBruto <= 4190.83)
            {
                desconto = salBruto * 0.12;
                salLiq = salBruto - desconto;
                Console.WriteLine($"Funcionário {nome}, cargo {cargo}}\nSalário Bruto: {salBruto}\nDesconto: {desconto} \nSalário Líquido: {salLiq}");
            }
            else if (salBruto <= 8157.41 && salBruto >= 4190.84)
            {
                desconto = salBruto * 0.12;
                salLiq = salBruto - desconto;
                Console.WriteLine($"Funcionário {nome}, cargo {cargo}\nSalário Bruto: {salBruto}\nDesconto: {desconto} \nSalário Líquido: {salLiq}");
            }
            else
            {
                Console.WriteLine("Os impostos não se aplicam.");
                Console.WriteLine($"Funcionário {nome}, cargo {cargo}\nSalário Bruto: {salBruto}\nDesconto: {desconto} \nSalário Líquido: {salLiq}");
            }
        }
    }
}
