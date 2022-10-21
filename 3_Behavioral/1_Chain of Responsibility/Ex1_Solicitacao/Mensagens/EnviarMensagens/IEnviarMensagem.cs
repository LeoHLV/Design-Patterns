namespace Ex1_Solicitacao.Mensagens.EnviarMensagens
{
    public interface IEnviarMensagem
    {
        public void Enviar(List<Mensagem> mensagens);
        IEnviarMensagem CriarEnvio(string tipo);
        IEnviarMensagem ProximoEnvio { get; set; }
    }
}