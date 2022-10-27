namespace ex1_SeletorEstiloData
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IAbstractExpression> expressoes = new List<IAbstractExpression>();

            Context context = new Context(DateTime.Now);
            Console.WriteLine($"Data atual : {context.Data}\n");

            Console.WriteLine("Selecione a experssão a usar : MM-DD-YYYY ou YYYY-MM-DD " +
                    "ou DD-MM-YYYY");

            // recebendo a data
            context.Expressao = Console.ReadLine().ToUpper();
            string[] formato = context.Expressao.Split('-');

            foreach (var item in formato)
            {
                switch (item)
                {
                    case "DD": expressoes.Add(new ExpressaoDia()); break;
                    case "MM": expressoes.Add(new ExpressaoMes()); break;
                    case "YYYY": expressoes.Add(new ExpressaoYear()); break;
                    default: Console.WriteLine("Formato inválido"); break;
                }
            }
            expressoes.Add(new Separador());

            foreach (var obj in expressoes)
            {
                obj.Avaliar(context);
            }

            Console.WriteLine($"\nData na expressão escolhida : {context.Expressao}");
        }
    }
}