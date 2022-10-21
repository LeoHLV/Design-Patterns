namespace PadraoProjetoState.Estados
{
    internal class PedidoFinalizado : IEstadoPedido
    {
        public void Aprovado(Pedido pedido) => throw new Exception("Pedido já finalizado, estado não pode ser alterado.");

        public void EmAndamento(Pedido pedido) => throw new Exception("Pedido já finalizado, estado não pode ser alterado");

        public void Finalizado(Pedido pedido) => throw new Exception("Pedido já finalizado.");

        public void Reprovado(Pedido pedido) => throw new Exception("Pedido já finalizado, estado não pode ser alterado");
    }
}