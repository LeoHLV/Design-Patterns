namespace PadraoProjetoStrategy.Strategy.EnviarMensagem
{
    public class MsgSms : IMensagem
    {
        public void Enviar(List<Mensagem> mensagens)
        {
            // contexto necessario para enviar o sms....
            Console.WriteLine("Sms enviado.");
        }
    }
}