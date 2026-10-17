using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPoo.Abstracao
{
    public interface INotificador
    {
        // Apenas metodos
        void Enviar(string mensagem);
    }

    public class Email : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Email disparado: {mensagem}");
        }
    }

    // Notificação SMS

    public class SMS : INotificador
    {


       public void Enviar(string mensagem)
        {
            Enviar(mensagem);
            Console.WriteLine($"Email disparado: {mensagem}");
        }
    }

    public class Loja
    {
        public void Finalizar(INotificador notificador)
        {
            notificador.Enviar("Compra finalizada");
        }
    }
    
}
