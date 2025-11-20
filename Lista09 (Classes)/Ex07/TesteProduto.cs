using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class TesteProduto
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("produto1", 25.50, "marca1", "M");
            Etiqueta e2 = new Etiqueta("marca2", "G");
            Produto p2 = new Produto("produto2", 250.50, e2);

            Console.WriteLine("*** Produtos originais ***");
            Console.WriteLine(p1); 
            Console.WriteLine(p2);

            p1.Nome = "Novo produto1";
            p1.Preco = 35.99;
            p2.Preco = 25.05;
            e2.Tamanho = "M";

            Console.WriteLine("\n*** Produtos alterados ***");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
