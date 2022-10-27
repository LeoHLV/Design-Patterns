namespace ex1_SeletorEstiloData
{
    public class ExpressaoYear : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            string expressao = context.Expressao;
            context.Expressao = expressao.Replace("YYYY", context.Data.Year.ToString());
        }
    }
}