using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Cargo c1 = new Cargo(123, 15.00);
            Cargo c2 = new Cargo(456, 25.00);
            Cargo c3 = new Cargo(789, 30.00);

            Funcionario f1 = new Funcionario(c1, 'F', 40);
            Funcionario f2 = new Funcionario(c2, 'M', 20);
            Funcionario f3 = new Funcionario(c3, 'F', 30);

            Console.WriteLine($"Salario funcionário 1: R${f1.Salario(f1.HorasTrabalhadas, c1.ValorHora)}");
            Console.WriteLine($"Salario funcionário 2: R${f2.Salario(f2.HorasTrabalhadas, c2.ValorHora)}");
            Console.WriteLine($"Salario funcionário 3: R${f3.Salario(f3.HorasTrabalhadas, c3.ValorHora)}");
        }
    }
}
