namespace Visitor
{
    public class ProcoVisitor : IVisitor
    {
        private const int _CARRO_DESCONTO = 12;
        void IVisitor.Accept(Carro carro)
        {
            decimal precoCarroAposDesconto = carro.Preco - ((carro.Preco / 100) * _CARRO_DESCONTO);

            Console.WriteLine($"{carro.Modelo} {carro.Nome} :" + $" ${precoCarroAposDesconto} ");
        }
    }
}