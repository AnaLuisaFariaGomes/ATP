using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class CaixaEletronico
    {
        static void Main(string[] args)
        {
            Agencia a1 = new Agencia("Pampulha", 7890, 5);
            ContaCorrente cc1 = new ContaCorrente(1234, 4, 150.00, a1);
            Cliente c1 = new Cliente("Ademar da Silva", "123.231.518-12", cc1);

            cc1.Sacar(140.00);
            Console.WriteLine();
            cc1.ConsultarSaldo();
            Console.WriteLine();
            cc1.Sacar(200.00);
            Console.WriteLine();
            cc1.ConsultarSaldo();
            cc1.Depositar(25.45);
        }
    }
}
