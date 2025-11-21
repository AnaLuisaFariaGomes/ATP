using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class ContaCorrente
    {
		private int numero;
		private int digito;
		private double saldo;
		private Agencia agencia;

		public Agencia Agencia
		{
			get { return agencia; }
			set { agencia = value; }
		}

		public double Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}


		public int Digito
		{
			get { return digito; }
			set { digito = value; }
		}


		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

        public ContaCorrente(int numero, int digito, double saldo, Agencia agencia)
        {
            this.numero = numero;
            this.digito = digito;
            this.saldo = saldo;
            this.agencia = agencia;
        }

        // MÉTODOS
        public void Depositar(double valor)
		{
			this.saldo += valor;
		}

		public void Sacar(double valor)
		{
			if (this.saldo >= valor)
			{
				this.saldo -= valor;
			}
			else
			{
				Console.WriteLine("Saldo insuficiente!");
            }
        }

		public void ConsultarSaldo()
		{
			Console.WriteLine(agencia);
			Console.WriteLine($"Conta corrente: {numero}-{saldo}");
            Console.WriteLine($"Saldo atual: {saldo}");
		}
    }
}
