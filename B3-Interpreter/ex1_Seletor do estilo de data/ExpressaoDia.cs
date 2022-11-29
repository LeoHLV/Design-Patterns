namespace ex1_SeletorEstiloData
{
    public class ExpressaoDia : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            string expressao = context.Expressao;
            context.Expressao = expressao.Replace("DD", context.Data.Day.ToString());
        }
    }
}