namespace Ex1_Solicitacao.Mensagens.EnviarMensagens
{
    // seleciona qual o tipo de Mensagem enviar
    public class EnviarSeletor
    {
        public void Enviar(List<Mensagem> mensagens, string tipo)
        {
            var enviarEmail = new EnviarEmail();
            var enviarSms = new EnviarSms();
            var enviarPush = new EnviarPush();
            var enviarSemCanal = new EnviarSemCanal();

            enviarEmail.ProximoEnvio = enviarSms;
            enviarSms.ProximoEnvio = enviarPush;
            enviarPush.ProximoEnvio = enviarSemCanal;

            var enviaMensagem = enviarEmail.CriarEnvio(tipo);
            enviaMensagem.Enviar(mensagens);
        }
    }
}