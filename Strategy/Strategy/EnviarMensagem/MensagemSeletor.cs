namespace PadraoProjetoStrategy.Strategy.EnviarMensagem
{
    public class MensagemSeletor
    {
        public void Enviar(List<Mensagem> mensagens, string tipo)
        {
            IMensagem enviarMensagem;
            if (tipo.ToLower() == "email")
            {
                enviarMensagem = new MsgEmail();
                enviarMensagem.Enviar(mensagens);
            }
            else if (tipo.ToLower() == "sms")
            {
                enviarMensagem = new MsgSms();
                enviarMensagem.Enviar(mensagens);
            }
            else if (tipo.ToLower() == "push")
            {
                enviarMensagem = new MsgPush();
                enviarMensagem.Enviar(mensagens);
            }
        }
    }
}