namespace Visitor
{
    //ConcreteVisitor
    public class PrecoVisitor : IVisitor
    {
        private const int _CARRO_DESCONTO = 12;

        public void Accept(Carro carro)
        {
            decimal precoCarroAposDesconto = carro.Preco
                - ((carro.Preco / 100) * _CARRO_DESCONTO);

            Console.WriteLine($"{carro.Modelo}{carro.Nome} :" +
                $" ${precoCarroAposDesconto} ");
        }
    }
}