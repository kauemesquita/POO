using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPoo.Polimorfismo.Exercicios
{
  public class Instrumento
    {
        public virtual void Tocar()
        {
            Console.WriteLine("Tocando um instrumento...");
        }
    }

    internal class Violao : Instrumento
    {
        public override void Tocar()
        {
            Console.WriteLine("Violão: plim plim");
        }
    }
}


