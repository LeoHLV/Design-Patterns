namespace Ex1_Solicitacao.Mensagens.EnviarMensagens
{
    public class EnviarPush : IEnviarMensagem
    {
        public IEnviarMensagem ProximoEnvio { get; set; }

        public IEnviarMensagem CriarEnvio(string tipo)
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