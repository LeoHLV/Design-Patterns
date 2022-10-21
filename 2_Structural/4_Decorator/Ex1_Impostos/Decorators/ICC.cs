namespace Ex1_Impostos.Decorators
{
    public class ICC : ImpostoDoProduto
    {
        public ICC() { }
        public ICC(ImpostoDoProduto outroProduto) : base(outroProduto)
        {
        }

        public override double Calcular(Produto produto)
        {
            return (produto.Valor * 0.05) + CalcularOutroImposto(produto);
        }
    }
}