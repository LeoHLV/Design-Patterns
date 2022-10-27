namespace Ex1_Impostos.Decorators
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}