using System;
using System.IO;
using System.Text;

namespace Ex06
{
    internal class Program
    {
        static void NomeporPessoaArquivo(string caminhoUsuarios, string caminhoRelatorio)
        {
            string linhaUsuarios;

            long tamanhoHD = 53687091200;
            long totalOcupado = 0;

            try
            {
                StreamReader arqUsuarios = new StreamReader(caminhoUsuarios, Encoding.UTF8);
                StreamWriter arqRelatorio = new StreamWriter(caminhoRelatorio, false, Encoding.UTF8);

                linhaUsuarios = arqUsuarios.ReadLine();

                while (linhaUsuarios != null)
                {
                    string[] info = linhaUsuarios.Split('/');
                    string nomeFuncionario = info[0];
                    long bytesUsados = long.Parse(info[1]);

                    double percentualUso = (bytesUsados * 100.0) / tamanhoHD;

                    arqRelatorio.WriteLine($"{nomeFuncionario}/{percentualUso:F2}%");

                    totalOcupado += bytesUsados;

                    linhaUsuarios = arqUsuarios.ReadLine();
                }

                double percentualTotal = (totalOcupado * 100.0) / tamanhoHD;

                arqRelatorio.WriteLine();
                arqRelatorio.WriteLine($"Ocupado: {totalOcupado}bytes");
                arqRelatorio.WriteLine($"Percentual: {percentualTotal:F2}%");

                arqUsuarios.Close();
                arqRelatorio.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            //string caminho1 = @"C:\Users\analu\OneDrive\Documentos\PUC Minas\1° Semestre\ATP\Lista10\usuarios.txt";
            //string caminho2 = @"C:\Users\analu\OneDrive\Documentos\PUC Minas\1° Semestre\ATP\Lista10\relatorio.txt";
          
            Console.WriteLine("Digite o caminho de usuarios.txt: ");
            string caminho1 = Console.ReadLine();
            Console.WriteLine("Digite o caminho de relatório.txt: ");
            string caminho2 = Console.ReadLine();

            NomeporPessoaArquivo(caminho1, caminho2);
        }
    }
}
