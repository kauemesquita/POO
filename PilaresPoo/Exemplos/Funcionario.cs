using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPoo.Exemplos
{
    internal class Funcionario
    {
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        //Atributos
        public string Nome { get; set; }
        public double Salario { get; set; }


        //Metodos
    }
}
