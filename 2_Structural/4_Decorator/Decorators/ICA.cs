using System.Net.Http.Headers;
namespace EstudoCS.Decorators
{
    public class ICA : ImpostoDoProduto
    {
        public ICA() {}
        public ICA(ImpostoDoProduto outroProduto) : base(outroProduto)
        {
        }

        public override double Calcular(Produto produto)
        {
           return (produto.Valor * 0.15) + CalcularOutroImposto(produto);
        }
    }
}