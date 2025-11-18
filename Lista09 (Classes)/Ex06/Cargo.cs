using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Cargo
    {
		private int codigo;
		private double valorHora;

		public double ValorHora
		{
			get { return valorHora; }
			set { valorHora = value; }
		}
		public int Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}

        public Cargo(int codigo, double valor_hora)
        {
            this.codigo = codigo;
            this.valorHora = valor_hora;
        }

        public Cargo()
        {
			codigo = 0;
			valorHora = 0;
        }
    }
}
