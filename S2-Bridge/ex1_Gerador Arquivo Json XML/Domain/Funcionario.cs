namespace Bridge.Domain
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Incentivo { get; set; }
        public decimal SalarioTotal { get; set; }
    }
}