using FactoryMethod.Pizzarias.PizzasRJ;

namespace FactoryMethod.Pizzarias.Fabricas
{
    public class PizzaFactoryRJ : AbsPizzaFactoryMethod
    {
        protected override AbsPizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M")) { return new PizzaMussarelaRJ(); }
            if (tipo.Equals("C")) { return new PizzaCalabrezaRJ(); }
            else return null;
        }
    }
}