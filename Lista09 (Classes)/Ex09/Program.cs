using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vagaOcupada;
            Estacionamento e = new Estacionamento("Estacionamento", 10);
            vagaOcupada = e.Estacionar("HKT0098");
            vagaOcupada = e.Estacionar("OLP4290");
            vagaOcupada = e.Estacionar("HJB0495");
            vagaOcupada = e.Estacionar("OWB3904");
            Console.WriteLine("Ocupação após a chegada de quatro clientes:");
            e.ExibirOcupacao();
            //HKT0098 OLP4290 HJB0495 OWB3904 vazia vazia vazia vazia vazia vazia
            vagaOcupada = e.ObterVagaOcupada("HKT0098");
            Console.WriteLine($"Veículo HKT0098 está na vaga {vagaOcupada}");
            // Veículo HKT0098 está na vaga 0
            e.RetirarVeiculo("HKT0098");
            Console.WriteLine("Após a retirada do veículo de placa HKT0098:");
            e.ExibirOcupacao();
            //vazia OLP4290 HJB0495 OWB3904 vazia vazia vazia vazia vazia vazia
            vagaOcupada = e.Estacionar("HTP5619");
            vagaOcupada = e.Estacionar("BOL4861");
            vagaOcupada = e.Estacionar("HGT9436");
            Console.WriteLine("Ocupação após a chegada de mais 3 clientes:");
            e.ExibirOcupacao();
            //HTP5619 OLP4290 HJB0495 OWB3904 BOL4861 HGT9436 vazia vazia vazia vazia
            Console.WriteLine($"Vagas livres: {e.ObterNumVagasLivres()}");
            //Vagas livres: 4
            Console.ReadLine();
        }
    }
}
