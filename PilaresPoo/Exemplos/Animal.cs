using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPoo.Exemplos
{
    internal class Animal
    {
        //Atributos

        public string Nome;

        //Metodos
        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo!");
        }
    }
}
