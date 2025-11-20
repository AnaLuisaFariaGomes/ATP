using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Produto
    {
        private string nome;
		private double preco;
		private Etiqueta etiqueta;

		public Etiqueta Etiqueta
		{
			get { return etiqueta; }
		}

		public double Preco
		{
			get { return preco; }
			set { preco = value; }
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

        public Produto(string nome, double preco, string marca, string tamanho)
        {
            Nome = nome;
            Preco = preco;
            etiqueta = new Etiqueta(marca, tamanho);
        }

        public Produto(string nome, double preco, Etiqueta etiqueta)
        {
            this.nome = nome;
            this.preco = preco;
            this.etiqueta = etiqueta;
        }

        public override string ToString()
        {
            return $"{nome} | {Etiqueta} | R${preco}";
        }
    }
}
