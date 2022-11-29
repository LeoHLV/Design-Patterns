namespace PadraoProjetoState.Estados
{
    public class Pedido
    {
        public string Descricao { get; set; }
        public double ValorTotal { get; set; }
        public IEstadoPedido EstadoAtual { private get; set; }

        public Pedido(string descricao, double valorTotal)
        {
            Descricao = descricao;
            ValorTotal = valorTotal;
            EstadoAtual = new PedidoEmAndamento();
        }
        public void EmAndamento()
        {
            EstadoAtual.EmAndamento(this);
            Console.WriteLine("Pedido em andamento");
        }
        public void Aprovado()
        {
            EstadoAtual.Aprovado(this);
            Console.WriteLine("Pedido aprovado.");
        }
        public void Reprovado()
        {
            EstadoAtual.Reprovado(this);
            Console.WriteLine("Pedido reprovado");
        }
        public void Finalizado()
        {
            EstadoAtual.Finalizado(this);
            Console.WriteLine("Pedido finalizado.");
        }
    }
}








































