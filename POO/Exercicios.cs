using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Pessoa
    {

        //Atributos
        public string Nome;
       
        public int Idade;
     

        //Metodos

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos ");
        }
    }
}
