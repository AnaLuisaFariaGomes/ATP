using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Etiqueta
    {
		private string marca;
		private string tamanho;

		public string Tamanho
		{
			get { return tamanho; }
			set { tamanho = value; }
		}


		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}

        public Etiqueta(string marca, string tamanho)
        {
            this.marca = marca;
            this.tamanho = tamanho;
        }

        public Etiqueta()
        {
			marca = "Indefinida";
			tamanho = "Indefinido";
        }

        public override string ToString()
        {
            return $"{Marca} | tam: {Tamanho}";
        }
    }
}
