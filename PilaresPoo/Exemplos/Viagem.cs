using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPoo.Exemplos
{
    internal class Viagem
    {
        //Atributos
        public string Destino;
        public int Dias;
        public double ValorDiaria;

        public Viagem(string destino, int dias, double valorDiaria)
        {
            Destino = destino;
            Dias = dias;
            ValorDiaria = valorDiaria;
        }

        public double CalcularTotal()
        {
            double total = Dias * ValorDiaria;
                return total;
        }

        public void Exibir()
        {
            Console.WriteLine($"A viagem será para {Destino} deve chegar em {Dias} dias e o valor da diaria é {ValorDiaria}");
        }

    }
}
