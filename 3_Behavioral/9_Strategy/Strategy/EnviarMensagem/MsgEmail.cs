namespace PadraoProjetoStrategy.Strategy.EnviarMensagem
{
    internal class MsgEmail : IMensagem
    {
        public void Enviar(List<Mensagem> mensagens)
        {
             // contexto necessario para enviar o push....
            Console.WriteLine("Email enviado.");
        }
    }
}