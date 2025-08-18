using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class _06
    {
        static void Main(string[] args)
        {
            double varA, varB, guardado;

            //dados solicitados ao user
            Console.WriteLine("Digite o valor da variável A: ");
            varA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da variável B: ");
            varB = double.Parse(Console.ReadLine());

            //questão
            guardado = varA;
            varA = varB;
            varB = guardado;
            Console.WriteLine($"valores atualizados varA = {varA}, varB = {varB}");
        }
    }
}
