using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class Estacionamento
    {
		private string nome;
		private int numTotalVagas;
		private int numVagasLivres;
		private string[] vagas;

		public string[] Vagas
		{
			get { return vagas; }
			set { vagas = value; }
		}

		public int NumVagasLivres
		{
			get { return numVagasLivres; }
			set { numVagasLivres = value; }
		}

		public int NumTotalVagas
		{
			get { return numTotalVagas; }
			set { numTotalVagas = value; }
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

        public Estacionamento(string nome, int totalVagas)
        {
            Nome = nome;
            NumTotalVagas = totalVagas;
            NumVagasLivres = totalVagas;
            Vagas = new string[totalVagas];
        }

        // METODOS

        public int Estacionar(String placa)
		{
			for (int i = 0; i < Vagas.Length; i++)
			{
				if (vagas[i] == null)
				{
					vagas[i] = placa;
					numVagasLivres--;
					return i;
                }
			}
			return -1;
        }
        public int ObterVagaOcupada(String placa)
		{
			for (int i = 0; i < Vagas.Length; i++)
			{
				if (vagas[i] == placa)
				{
					return i;
				}
            }
			return -1;
        }
        public void RetirarVeiculo(String placa)
		{
			for (int i = 0; i < Vagas.Length; i++)
			{
				if (vagas[i] == placa)
				{
					vagas[i] = null;
					numVagasLivres++;
				}
            }
        }
        public int ObterNumVagasLivres()
		{
			return numVagasLivres;
        }
        public void ExibirOcupacao()
		{
			for (int i = 0; i < Vagas.Length; i++)
			{
				if (vagas[i] != null)
				{
					Console.WriteLine("Vaga " + i + ": " + vagas[i]);
				}
				else
				{
					Console.WriteLine("Vaga " + i + " vazia");
				}
            }
        }
    }
}
