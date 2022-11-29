using Ex1_Solicitacao.Mensagens.EnviarMensagens;

namespace Ex1_Solicitacao.Mensagens
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagens = new List<Mensagem>();
            mensagens.Add(new Mensagem("Pedro@teste.com", "Obrigado por se cadastrar."));
            mensagens.Add(new Mensagem("Carlos@teste.com", "Obrigado por se cadastrar."));
            mensagens.Add(new Mensagem("Sandro@teste.com", "Obrigado por se cadastrar."));
            mensagens.Add(new Mensagem("Luis@teste.com", "Obrigado por se cadastrar."));
            var enviarMensagem = new EnviarSeletor();
            enviarMensagem.Enviar(mensagens, "email");
        }
    }
}