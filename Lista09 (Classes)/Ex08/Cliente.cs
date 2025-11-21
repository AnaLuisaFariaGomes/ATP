using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class Cliente
    {
        private string nome;
        private string cpf;
		private ContaCorrente contaCorrente;

		public ContaCorrente ContaCorrente
		{
			get { return contaCorrente; }
			set { contaCorrente = value; }
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public string Cpf
		{
			get { return cpf; }
			set { cpf = value; }
		}

        public Cliente(string nome, string cpf, ContaCorrente contaCorrente)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.contaCorrente = contaCorrente;
        }
    }
}
