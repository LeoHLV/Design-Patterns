namespace Ex1_Solicitacao.Mensagens
{
    public class Mensagem
    {
        public string Destino { get; private set; }
        public string Texto { get; private set; }

        public Mensagem(string destino, string texto)
        {
            Destino = destino;
            Texto = texto;
        }

    }
}