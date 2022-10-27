namespace PadraoProjetoState.Estados
{
    internal class PedidoReprovado : IEstadoPedido
    {
        public void Aprovado(Pedido pedido) => throw new Exception("Pedidos em estado de reprovado não podem ser aprovados");

        public void EmAndamento(Pedido pedido) => pedido.EstadoAtual = new PedidoEmAndamento();

        public void Finalizado(Pedido pedido) => pedido.EstadoAtual = new PedidoFinalizado();

        public void Reprovado(Pedido pedido) => throw new Exception("Pedido já reprovado.");
    }
}