namespace PadraoChainOfResponsibility.Strategy.ComPadrao
{
    public class EnviaMensagemEmail : IEnviaMensagem
    {
        public IEnviaMensagem ProximoEnvio { get; set; }

        public IEnviaMensagem CriarEnvio(string tipo)
        {
            if (tipo != "email") { return ProximoEnvio.CriarEnvio(tipo); }
            return this;
        }

        public void Enviar(List<Mensagem> mensagens)
        {
            // contexto necessario para enviar o email....
            Console.WriteLine("Email enviado.");
        }
    }
}