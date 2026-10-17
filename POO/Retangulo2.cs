using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Retangulo2
    {

        //Atributo

        public double Largura;

        public double Altura;

        public double CalcularArea()
        {
            double area = Largura * Altura;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 2 * (Largura + Altura);
            return perimetro;
        }

    }
}
