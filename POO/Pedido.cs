using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Pedido
    {
        public string Item;
        public int Quantidade;
        public double Preco;


        public void ExibirInformacoes()
        {
            Console.WriteLine($"Item {Item}");
            Console.WriteLine($"Quantidade {Quantidade}");
            Console.WriteLine($"Preco {Preco}");
        }
    }
}