using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Aluno
    {
        private string nome;
        private int matricula;
        private double[] notas = new double[3];

        public Aluno(string nome, int matricula, double[] notas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.notas = notas;
        }

        public double CalcularMedia()
        {
            double soma = 0;
            int cont = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
                cont++;
            }
            double media = soma / cont;
            return media;
        }

        public override string ToString()
        {
            return $"Aluno: {nome}\nMatricula: {matricula}";
        }
    }
}
