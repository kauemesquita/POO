using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPoo.Heranca
{
    internal class Carro : Veiculo
    {

        //Atributos
        public Carro(string marca, string modelo, int portas) : base(marca, modelo)
        {
            Portas = portas;
        }
        public int Portas { get; set; }
        public void ExibirPortas()
        {
            Console.WriteLine(Portas);
        }
    }
}
