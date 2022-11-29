namespace ex1_SeletorEstiloData
{
    public class Separador : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            string expressao = context.Expressao;
            context.Expressao = expressao.Replace(" ", "-");
        }
    }
}