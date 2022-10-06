namespace PadraoChainOfResponsibility.Strategy.ComPadrao
{
    public class EnviaMensagemSms : IEnviaMensagem
    {
        public IEnviaMensagem ProximoEnvio { get; set; }

        public IEnviaMensagem CriarEnvio(string tipo)
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