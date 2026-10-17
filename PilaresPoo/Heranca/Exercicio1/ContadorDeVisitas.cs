using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPoo.Heranca.Exercicio1
{
    internal class ContadorDeVisitas
    {
        private int Visitas { get; set; }

        public void RegistrarVisita()
        {
            //Visitas +1
            Visitas++;

            //Mesma coisa da linha de cima
            Visitas = Visitas + 1;  
        }

        public int ObterTotal()
        {
           return Visitas;
        }
    }
}
