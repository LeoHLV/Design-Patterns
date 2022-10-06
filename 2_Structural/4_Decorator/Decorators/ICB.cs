namespace EstudoCS.Decorators
{
    public class ICB : ImpostoDoProduto
    {
        public ICB(){}
        public ICB(ImpostoDoProduto outroProduto) : base(outroProduto)
        {
        }

        public override double Calcular(Produto produto)
        {
            return(produto.Valor * 0.1) + CalcularOutroImposto(produto);
        }
    }
}