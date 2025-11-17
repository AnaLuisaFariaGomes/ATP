using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Maria", "Rua 1", "31 9999-9999");
            Console.WriteLine("Cliente 1: "+ c1);
            Cliente c2 = new Cliente("João", "Rua 2", "31 8888-8888");
            Console.WriteLine("Cliente 2: "+ c2);
            Cliente c3 = new Cliente();
            Console.WriteLine("Digite o nome do cliente 3: ");
            c3.Nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço do cliente 3: ");
            c3.Endereco = Console.ReadLine();
            Console.WriteLine("Digite o telefone do cliente 3: ");
            c3.Telefone = Console.ReadLine();  
            Console.WriteLine("Cliente 3: "+ c3);
        }
    }
}
