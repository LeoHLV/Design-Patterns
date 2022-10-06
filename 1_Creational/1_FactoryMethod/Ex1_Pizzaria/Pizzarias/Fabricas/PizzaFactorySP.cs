using FactoryMethod.Pizzarias.PizzasSP;

namespace FactoryMethod.Pizzarias.Fabricas
{
    //Concrete Creator
    public class PizzaFactorySP : AbsPizzaFactoryMethod
    {
        protected override AbsPizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M")) { return new PizzaMussarelaSP(); }
            if (tipo.Equals("C")) { return new PizzaCalabrezaSP(); }
            else return null;
        }
    }
}