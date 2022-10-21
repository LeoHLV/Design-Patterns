namespace PadraoProjetoState.Estados
{
    public interface IEstadoPedido
    {
        void EmAndamento(Pedido pedido);
        void Aprovado(Pedido pedido);
        void Reprovado(Pedido pedido);
        void Finalizado(Pedido pedido);
    }
}