using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using AbstractFactory.Factorys.AbstractFactory;

namespace AbstractFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            // obter fabricas
            var boloFactory = MassasAbstractFactory.CriaFabricaMassas(Domain.Enums.TipoMassa.Bolo);
            var pizzaFactory = MassasAbstractFactory.CriaFabricaMassas(Domain.Enums.TipoMassa.Pizza);

            // criar objetos com base no tipo : bolo
            var bolo1 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Chocolate);
            var bolo2 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Laranja);

            // criar objetos com base no tipo : pizza
            var pizza1 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Calabreza);
            var pizza2 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Mussarela);

            // exibe detalhes
            ExibeDetalhes(bolo1);
            ExibeDetalhes(bolo2);
            ExibeDetalhes(pizza1);
            ExibeDetalhes(pizza2);
        }

        private static void ExibeDetalhes(MassaBase massaBase)
        {
            Console.WriteLine($"Tipo : {massaBase.TipoMassa}");
            Console.WriteLine(massaBase.Nome);
            Console.WriteLine(massaBase.Ingredientes[0].ToString() + "\n");
        }
    }
}
