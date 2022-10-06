namespace PadraoChainOfResponsibility.Strategy.ComPadrao
{
    class EnviaMensagemSemCanal : IEnviaMensagem
    {
        public EnviaMensagemSemCanal() { }

        public IEnviaMensagem ProximoEnvio { get; set; }

        public IEnviaMensagem CriarEnvio(string tipo) => this;

        public void Enviar(List<Mensagem> mensagens) => Console.WriteLine("Envio não possui canal.");
    }
}