namespace PadraoChainOfResponsibility.Strategy.ComPadrao
{
    public interface IEnviaMensagem
    {
        public void Enviar(List<Mensagem> mensagens);
        IEnviaMensagem CriarEnvio(string tipo);
        IEnviaMensagem ProximoEnvio { get; set; }
    }
}