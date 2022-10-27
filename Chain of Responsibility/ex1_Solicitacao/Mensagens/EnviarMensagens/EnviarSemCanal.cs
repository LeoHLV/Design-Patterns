namespace Ex1_Solicitacao.Mensagens.EnviarMensagens
{
    class EnviarSemCanal : IEnviarMensagem
    {
        public EnviarSemCanal() { }

        public IEnviarMensagem ProximoEnvio { get; set; }

        public IEnviarMensagem CriarEnvio(string tipo)
        {
            return this;
        }

        public void Enviar(List<Mensagem> mensagens)
        {
            Console.WriteLine("Envio não possui canal.");
        }
    }
}