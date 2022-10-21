namespace Ex1_Solicitacao.Mensagens.EnviarMensagens
{
    public class EnviarEmail : IEnviarMensagem
    {
        public IEnviarMensagem ProximoEnvio { get; set; }

        public IEnviarMensagem CriarEnvio(string tipo)
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