using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class _04
    {
        static void Main(string[] args)
        {
            double fahrenheit, celcius;

            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celcius = ((5*(fahrenheit-32))/9);
            Console.WriteLine($"{fahrenheit}° Fahrenheit equivalem a {celcius}° celcius.");
        }
    }
}
