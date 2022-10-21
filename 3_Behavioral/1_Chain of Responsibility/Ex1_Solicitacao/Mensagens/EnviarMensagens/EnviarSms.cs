namespace Ex1_Solicitacao.Mensagens.EnviarMensagens
{
    public class EnviarSms : IEnviarMensagem
    {
        public IEnviarMensagem ProximoEnvio { get; set; }

        public IEnviarMensagem CriarEnvio(string tipo)
        {
            if (tipo != "sms") { return ProximoEnvio.CriarEnvio(tipo); }
            return this;
        }

        public void Enviar(List<Mensagem> mensagens)
        {
            // contexto necessario para enviar o sms....
            Console.WriteLine("Sms enviado.");
        }
    }
}