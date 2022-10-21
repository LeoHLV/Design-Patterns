namespace Ex1_Impostos.Decorators
{
    public abstract class ImpostoDoProduto
    {
        private ImpostoDoProduto _outroImposto;

        public ImpostoDoProduto(ImpostoDoProduto outroProduto)
        {
            _outroImposto = outroProduto;
        }

        // construtor para chamar comportamentos
        protected ImpostoDoProduto() => _outroImposto = null;

        // classe a ser implementada por cad imposto
        public abstract double Calcular(Produto produto);

        //vai calcular outro imposto
        protected double CalcularOutroImposto(Produto produto)
        {
            if(_outroImposto ==null) return 0;

            return _outroImposto.Calcular(produto);
        }


    }
}