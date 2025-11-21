using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class Agencia
    {
		private string nome;
		private int numero;
		private int digito;

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

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

        public Agencia(string nome, int numero, int digito)
        {
            this.nome = nome;
            this.numero = numero;
            this.digito = digito;
        }

        public override string ToString()
        {
            return $"Agência: {numero}-{digito}";
        }
    }
}
