using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo(5);
            Circulo c2 = new Circulo(3);
            Circulo c3 = new Circulo(2.5);
            Circulo c4 = new Circulo(6);

            Console.WriteLine("*** Círculo 1 ***");
            Console.WriteLine($"Raio:  {c1.Raio:F2}");
            Console.WriteLine($"Área: {c1.CalcularArea():F2}");
            Console.WriteLine($"Diametro: {c1.CalcularDiametro():F2}");
            Console.WriteLine($"Perímetro: {c1.CalcularPerimetro():F2}");

            Console.WriteLine("\n*** Círculo 2 ***");
            Console.WriteLine($"Raio:  {c2.Raio:F2}");
            Console.WriteLine($"Área: {c2.CalcularArea():F2}");
            Console.WriteLine($"Diametro: {c2.CalcularDiametro():F2}");
            Console.WriteLine($"Perímetro: {c2.CalcularPerimetro():F2}");

            Console.WriteLine("\n*** Círculo 3 ***");
            Console.WriteLine($"Raio:  {c3.Raio:F2}");
            Console.WriteLine($"Área: {c3.CalcularArea():F2}");
            Console.WriteLine($"Diametro: {c3.CalcularDiametro():F2}");
            Console.WriteLine($"Perímetro: {c3.CalcularPerimetro():F2}");

            Console.WriteLine("\n*** Círculo 4 ***");
            Console.WriteLine($"Raio:  {c4.Raio:F2}");
            Console.WriteLine($"Área: {c4.CalcularArea():F2}");
            Console.WriteLine($"Diametro: {c4.CalcularDiametro():F2}");
            Console.WriteLine($"Perímetro: {c4.CalcularPerimetro():F2}");
        }
    }
}
