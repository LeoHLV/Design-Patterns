namespace PadraoChainOfResponsibility.Strategy.ComPadrao
{
    public class EnviaMensagemComPadrao
    {
        public void Enviar(List<Mensagem> mensagens, string tipo)
        {
            var enviaMensagemEmail = new EnviaMensagemEmail();
            var enviaMensagemSms = new EnviaMensagemSms();
            var enviaMensagemPush = new EnviaMensagemPush();
            var enviaMensagemSemCanal = new EnviaMensagemSemCanal();
            enviaMensagemEmail.ProximoEnvio = enviaMensagemSms;
            enviaMensagemSms.ProximoEnvio = enviaMensagemPush;
            enviaMensagemPush.ProximoEnvio = enviaMensagemSemCanal;

            var enviaMensagem = enviaMensagemEmail.CriarEnvio(tipo);
            enviaMensagem.Enviar(mensagens);
        }
    }
}