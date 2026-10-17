using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPoo
{
    internal class Veiculo
    {

        //Atributos

        public string Marca { get; set; }
        public string Modelo {  get; set; }

        public Veiculo(string marca, string modelo) {
         
            Marca = marca;
            Modelo = modelo;
        }
       
      public void Exibir()
        {
            Console.WriteLine($"Seu carro é um {Marca} e o modelo é {Modelo}");
        }
    }
}
