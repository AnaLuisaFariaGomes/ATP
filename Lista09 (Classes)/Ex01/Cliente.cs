using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Cliente
    {
        private string nome;
        private string endereco;
        private string telefone;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Cliente(string nome, string endereco, string telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public Cliente()
        {
            nome = "";
            endereco = "";
            telefone = "";
        }

        public override string ToString()
        {
            return $"{nome}, {endereco}, {telefone}";
        }
    }
}
