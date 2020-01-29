using System;
using System.Collections.Generic;
using System.Text;

namespace Couse
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            double d = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
            return d;
        }
    }
}
