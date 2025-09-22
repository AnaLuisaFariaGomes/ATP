using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class _05
    {
        static void Main(string[] args)
        {
            int voto, contA = 0, contB = 0, contC = 0, contN = 0, contBranco = 0;
            char continuar;

            do
            {
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1 - Candidato 1");
                Console.WriteLine("2 - Candidato 2");
                Console.WriteLine("3 - Candidato 3");
                Console.WriteLine("4 - Voto Branco");
                Console.WriteLine("Digite o seu voto: ");
                voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        contA++;
                        Console.WriteLine("Você votou no Candidato 1");
                        break;
                    case 2:
                        Console.WriteLine("Você votou no Candidato 2");
                        contB++;
                        break;
                    case 3:
                        Console.WriteLine("Você votou no Candidato 3");
                        contC++;
                        break;
                    case 4:
                        Console.WriteLine("Você votou Branco");
                        contBranco++;
                        break;
                    default:
                        Console.WriteLine("Você votou nulo");
                        contN++;
                        break;
                }

                Console.WriteLine("Deseja continuar? (S ou N)");
                continuar = char.Parse(Console.ReadLine().ToUpper());
                Console.Clear();

            } while (continuar != 'N');

            Console.WriteLine("Total de votos para o Candidato 1: " + contA);
            Console.WriteLine("Total de votos para o Candidato 2: " + contB);
            Console.WriteLine("Total de votos para o Candidato 3: " + contC);

            if (contA > contB && contA > contC)
            {
                Console.WriteLine("O Candidato 1 venceu a eleição.");
            }
            else if (contB > contA && contB > contC)
            {
                Console.WriteLine("O Candidato 2 venceu a eleição.");
            }
            else if (contC > contA && contC > contB)
            {
                Console.WriteLine("O Candidato 3 venceu a eleição.");
            }
            else
            {
                Console.WriteLine("Houve um empate entre os candidatos.");
            }

            Console.WriteLine("Total de votos nulos: " + contN);
            Console.WriteLine("Total de votos em branco: " + contBranco);
        }
    }
}
