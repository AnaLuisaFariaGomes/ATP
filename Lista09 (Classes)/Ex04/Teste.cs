using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            double[] notas1 = { 6, 5, 7 };
            Aluno a1 = new Aluno("Aluno 1", 1234, notas1);

            double[] notas2 = { 8, 4, 7 };
            Aluno a2 = new Aluno("Aluno 2", 1234, notas2);

            double media1 = a1.CalcularMedia();
            double media2 = a2.CalcularMedia();

            Console.WriteLine("*** Aluno 1 ***");
            Console.WriteLine($"{a1} \nMédia: {media1:F2}");
            Console.WriteLine("\n*** Aluno 2 ***");
            Console.WriteLine($"{a2} \nMédia: {media2:F2}");
        }
    }
}
