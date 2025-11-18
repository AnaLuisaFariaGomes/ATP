using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Funcionario
    {
        Cargo cargo = new Cargo();
		private char sexo;
		private double horasTrabalhadas;

		public double HorasTrabalhadas
		{
			get { return horasTrabalhadas; }
			set { horasTrabalhadas = value; }
		}

		public char Sexo
		{
			get { return sexo; }
			set { sexo = value; }
		}

        public Funcionario(Cargo cargo, char sexo, double horasTrabalhadas)
        {
            this.cargo = cargo;
            this.sexo = sexo;
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public Funcionario(char sexo, double horasTrabalhadas)
        {
            this.sexo = sexo;
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public double Salario(double horasTrabalhadas, double valorHora)
        {
            return horasTrabalhadas * valorHora;
        }

        public override string ToString()
        {
            return $"Cod. Cargo: {cargo.Codigo}, Sexo: {sexo}\nR$/h: {cargo.ValorHora} | Horas trabalhadas: {horasTrabalhadas}";
        }
    }
}
