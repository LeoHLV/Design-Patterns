namespace PadraoProjetoStrategy.Strategy.EnviarMensagem
{
    public class MsgPush : IMensagem
    {
        public void Enviar(List<Mensagem> mensagens)
        {
            // contexto necessario para enviar o push....
            Console.WriteLine("Push enviado.");
        }
    }
}