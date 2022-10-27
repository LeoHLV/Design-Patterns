namespace ex1_SeletorEstiloData
{
    public class ExpressaoMes : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            string expressao = context.Expressao;
            context.Expressao = expressao.Replace("MM", context.Data.Month.ToString());
        }
    }
}