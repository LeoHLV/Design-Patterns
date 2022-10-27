namespace FactoryMethod.Pizzarias.PizzasRJ
{
    public class PizzaCalabrezaRJ : AbsPizza
    {
        public PizzaCalabrezaRJ()
        {
            Nome = "Pizza de calabreza carioca com cebola";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Fatias de calabreza especial");
            ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}