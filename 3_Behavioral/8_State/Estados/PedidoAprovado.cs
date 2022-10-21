namespace PadraoProjetoState.Estados
{
    internal partial class PedidoEmAndamento
    {
        private class PedidoAprovado : IEstadoPedido
        {
            public void Aprovado(Pedido pedido) => throw new Exception("Pedido já em estado de aprovação");

            public void EmAndamento(Pedido pedido) => pedido.EstadoAtual = new PedidoEmAndamento();

            public void Finalizado(Pedido pedido) => pedido.EstadoAtual = new PedidoFinalizado();

            public void Reprovado(Pedido pedido) => throw new Exception("Pedido em estado de aprovação não pode ser reprovado");
        }
    }
}