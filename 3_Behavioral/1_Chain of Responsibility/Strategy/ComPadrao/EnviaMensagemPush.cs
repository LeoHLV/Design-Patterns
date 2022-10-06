namespace PadraoChainOfResponsibility.Strategy.ComPadrao
{
    public class EnviaMensagemPush : IEnviaMensagem
    {
        public IEnviaMensagem ProximoEnvio { get; set; }

        public IEnviaMensagem CriarEnvio(string tipo)
        {
            if (tipo != "push") { return ProximoEnvio.CriarEnvio(tipo); }
            return this;
        }

        public void Enviar(List<Mensagem> mensagens)
        {
            // contexto necessario para enviar o push....
            Console.WriteLine("Push enviado.");
        }
    }
}