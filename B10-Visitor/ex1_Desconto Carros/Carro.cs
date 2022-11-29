namespace Visitor
{
    public class Carro : ILoja
    {
        public string Nome { get; set; } = "";
        public decimal Preco { get; set; }
        public string Modelo { get; set; } = "";

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}