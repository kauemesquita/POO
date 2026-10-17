using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPoo.Heranca
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Oi, eu sou o {Nome}, e tenho {Idade} anos!");
        }
    }
}
