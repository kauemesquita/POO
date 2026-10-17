using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class PessoaMetodo2
    {
        //Atributo
        public string Nome;

        //Metodo

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}");
        }
        public void CumprimentarAlguem(string outraPessoa)
        {
            Console.WriteLine($"Olá, {outraPessoa} eu sou {Nome}");
        }

        public string ObterApresentacao()
        {
            
            return $"Meu nome é {Nome}";
        }
    }
}