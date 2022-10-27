using FactorySimple.Pizzarias.PizzaTipos;

namespace FactorySimple.Pizzarias
{
    public sealed class PizzaSimpleFactory
    {
        public static AbsPizza CriarPizza(string tipo)
        {
            AbsPizza pizza;
            switch (tipo)
            {
                case "C": pizza = new PizzaCalabreza(); break;
                case "M": pizza = new PizzaMussarela(); break;

                default: throw new ApplicationException($"A pizza de '{tipo}' não foi encontrada.");
            }
            return pizza;
        }
    }
}