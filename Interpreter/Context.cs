namespace ex1_SeletorEstiloData
{
    public class Context
    {
        public string Expressao { get; set; }
        public DateTime Data { get; set; }

        public Context(DateTime data)
        {
            Data = data;
        }
    }
}