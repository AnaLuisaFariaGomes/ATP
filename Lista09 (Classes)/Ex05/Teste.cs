using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Cliente[] clientes = new Cliente[10];

            for (int i = 0; i < clientes.Length; i++)
            {
                string nome, endereco, telefone;
                Console.WriteLine($"*** Cliente {i + 1} ***");
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Endereço: ");
                endereco = Console.ReadLine();
                Console.WriteLine("Telefone: ");
                telefone = Console.ReadLine();

                clientes[i] = new Cliente(nome, endereco, telefone);
            }

            Console.WriteLine("Renomeie o cliente 1: ");
            clientes[0].Nome = Console.ReadLine();

            Console.WriteLine("\n*** CLIENTES ***");
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine(clientes[i]);
            }
        }
    }
}
