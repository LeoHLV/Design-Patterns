using FactoryMethod.Pizzarias.Fabricas;

namespace FactoryMethod.Pizzarias
{
    public class PizzaSimpleFactory
    {
        public static AbsPizzaFactoryMethod CriarPizzaria(string local)
        {
            AbsPizzaFactoryMethod pizzaria;
            switch (local)
            {
                case "S": pizzaria = new PizzaFactorySP(); break;
                case "R": pizzaria = new PizzaFactoryRJ(); break;
                default: throw new ApplicationException($"A pizzaria {local} não ");
            }
            return pizzaria;
        }
    }
}