using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Circulo
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public double CalcularArea()
        {
            return raio * Math.PI;
        }

        public double CalcularDiametro()
        {
            return 2 * raio;
        }

        public double CalcularPerimetro()
        {
            return 2 * CalcularArea();
        }
    }
}
