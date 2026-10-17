using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Retangulo
    {

        //Atributos

        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            double Area = Largura * Altura;
            return Area;
        }

        public double CalcularPerimetro()
        {
            double Perimetro = 2 * (Largura * Altura);
            return Perimetro;
        }
    }
}