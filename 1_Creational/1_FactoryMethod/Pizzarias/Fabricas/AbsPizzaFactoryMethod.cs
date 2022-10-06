namespace FactoryMethod.Pizzarias.Fabricas
{
    //Creator
    public abstract class AbsPizzaFactoryMethod
    {
        protected abstract AbsPizza CriarPizza(string tipo);

        public AbsPizza MontaPizza(string tipo)
        {
            AbsPizza pizza;
            pizza = CriarPizza(tipo);
            return pizza;
        }
    }
}