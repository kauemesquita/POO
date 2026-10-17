using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPoo.Heranca.Exercicio2
{
    internal class Boletim
    {
        public string Aluno { get; set; }
        private double Nota;

        public void DefinirNota(double valor)
        {
            if(valor >= 0 &&  valor <=10)
            {
                Nota = valor;
            }
            else
            {
                Console.WriteLine($"Nota invalida: {valor}");
            }


        }

        public double ObterNota()
        {
            return Nota;
        }
    }
}
